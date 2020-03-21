﻿using IdleMaster.Properties;
using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

namespace IdleMaster
{
    internal class SteamProfile
    {
        internal static string GetSteamId()
        {
            string steamid = WebUtility.UrlDecode(Settings.Default.steamLogin);
            return steamid?.Split('|').First();
        }

        internal static string GetSteamUrl()
        {
            return $"https://steamcommunity.com/profiles/{GetSteamId()}";
        }

        internal static string GetSignedAs()
        {
            string steamUrl = GetSteamUrl();
            string userName = $"User {GetSteamId()}";

            try
            {
                WebClient webClient = new WebClient
                {
                    Encoding = Encoding.UTF8
                };

                string xml = webClient.DownloadString($"{steamUrl}/?xml=1");

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xml);

                XmlNode xmlNode = xmlDocument.SelectSingleNode("//steamID");

                if (xmlNode != null)
                {
                    userName = WebUtility.HtmlDecode(xmlNode.InnerText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Exception(ex, $"frmMain -> GetSignedAs, for steamUrl = {steamUrl}");
            }

            return $"{localization.strings.signed_in_as} {userName}";
        }
    }
}