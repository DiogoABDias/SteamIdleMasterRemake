﻿using HtmlAgilityPack;
using IdleMaster.ControlEntities;
using IdleMaster.Enums;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;

namespace IdleMaster.Entities
{
    public class Library
    {
        //Properties
        public List<Game> Games { get; private set; }

        public bool HasGames
        {
            get
            {
                return Games != null && Games.Any();
            }
        }

        public bool IsIdling { get; private set; }

        public bool IsPaused { get; private set; }

        public int FirstIdlingIndex { get; private set; }

        //Constructors
        public Library()
        {
            Games = new List<Game>();
        }

        //Methods
        public void StartIdling()
        {
            if (!HasGames || IsIdling)
            {
                return;
            }

            FirstIdlingIndex = 0;

            foreach (Game game in Games.Skip(FirstIdlingIndex).Take(UserSettings.GamesToIdle))
            {
                game.StartIdling();
                game.Status = UserSettings.FastIdleEnabled ? GameStatus.FastIdling : GameStatus.NormalIdling;
            }

            IsIdling = true;
        }

        public void PauseIdling()
        {
            if (IsPaused)
            {
                return;
            }

            List<GameStatus> idleStatuses = new List<GameStatus>()
            {
                GameStatus.FastIdling,
                GameStatus.Restarting,
                GameStatus.NormalIdling
            };

            foreach (Game game in Games.Where(x => idleStatuses.Contains(x.Status)))
            {
                game.StopIdling();
            }

            IsPaused = true;
        }

        public void ResumeIdling()
        {
            if (!IsPaused)
            {
                return;
            }

            foreach (Game game in Games.Skip(FirstIdlingIndex).Take(UserSettings.GamesToIdle))
            {
                game.StartIdling();
            }

            IsPaused = false;
        }

        public void SkipIdling()
        {
            if (!IsIdling)
            {
                return;
            }

            Games[FirstIdlingIndex].StopIdling();
            Games[FirstIdlingIndex].Status = GameStatus.Stopped;

            Games[FirstIdlingIndex + UserSettings.GamesToIdle].StartIdling();
            Games[FirstIdlingIndex + UserSettings.GamesToIdle].Status = GameStatus.FastIdling;

            FirstIdlingIndex++;
        }

        public void StopIdling()
        {
            if (!IsIdling)
            {
                return;
            }

            List<GameStatus> idleStatuses = new List<GameStatus>()
            {
                GameStatus.FastIdling,
                GameStatus.Restarting,
                GameStatus.NormalIdling
            };

            foreach (Game game in Games.Where(x => idleStatuses.Contains(x.Status)))
            {
                game.StopIdling();
                game.Status = GameStatus.Stopped;
            }

            IsIdling = false;
            IsPaused = false;
        }

        public void CheckIdlingStatus(GameStatus gameStatus)
        {
            if (!IsIdling)
            {
                return;
            }

            foreach (Game game in Games.Where(x => x.Status == gameStatus))
            {
                HtmlDocument document = new HtmlDocument();
                string response = CookieClient.GetHttp($"{UserSettings.ProfileUrl}/gamecards/{game.AppId}");

                document.LoadHtml(response);

                HtmlNode cardsNode = document.DocumentNode.SelectSingleNode(".//span[@class='progress_info_bold']");
                string cards = cardsNode?.InnerText.Split(' ').First();

                HtmlNode playtimeNode = document.DocumentNode.SelectSingleNode(".//div[@class='badge_title_stats_playtime']");
                string playtime = WebUtility.HtmlDecode(playtimeNode?.InnerText).Trim().Split(' ').First();

                int.TryParse(cards, out int remainingCards);
                double.TryParse(playtime, NumberStyles.Any, new NumberFormatInfo(), out double hoursPlayed);

                game.UpdateStats(remainingCards, hoursPlayed);

                if (!game.HasDrops)
                {
                    game.StopIdling();
                }

                if (game.Status == GameStatus.FastIdling && game.FastIdleTries > 0)
                {
                    game.FastIdleTries--;

                    if (game.FastIdleTries == 0 && game.RemainingCards == game.OriginalRemainingCards)
                    {
                        game.Status = GameStatus.NormalIdling;
                    }
                }
            }
        }

        public void StartFastIdling()
        {
            foreach (Game game in Games.Where(x => x.Status == GameStatus.Restarting))
            {
                game.StartIdling();
                game.Status = GameStatus.FastIdling;
            }
        }

        public void StopFastIdling()
        {
            foreach (Game game in Games.Where(x => x.Status == GameStatus.FastIdling).ToList())
            {
                game.StopIdling();
                game.Status = GameStatus.Restarting;
            }
        }
    }
}