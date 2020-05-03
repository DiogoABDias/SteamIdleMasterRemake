﻿namespace IdleMaster
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrSteamStatus = new System.Windows.Forms.Timer(this.components);
            this.lnkSession = new System.Windows.Forms.LinkLabel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblSteam = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lsvBadges = new System.Windows.Forms.ListView();
            this.colGame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoursPlayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRemainingCards = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmrNormalIdleStatus = new System.Windows.Forms.Timer(this.components);
            this.tmrFastIdleStart = new System.Windows.Forms.Timer(this.components);
            this.tmrFastIdleStop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrSteamStatus
            // 
            this.tmrSteamStatus.Interval = 500;
            this.tmrSteamStatus.Tick += new System.EventHandler(this.tmrSteamStatus_Tick);
            // 
            // lnkSession
            // 
            this.lnkSession.AutoSize = true;
            this.lnkSession.Location = new System.Drawing.Point(403, 9);
            this.lnkSession.Name = "lnkSession";
            this.lnkSession.Size = new System.Drawing.Size(33, 13);
            this.lnkSession.TabIndex = 1;
            this.lnkSession.TabStop = true;
            this.lnkSession.Text = "Login";
            this.lnkSession.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSession_LinkClicked);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::IdleMaster.Properties.Resources.Play;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Location = new System.Drawing.Point(372, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(32, 32);
            this.btnStart.TabIndex = 4;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::IdleMaster.Properties.Resources.Stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Location = new System.Drawing.Point(410, 79);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(33, 32);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblSteam
            // 
            this.lblSteam.AutoSize = true;
            this.lblSteam.Location = new System.Drawing.Point(9, 9);
            this.lblSteam.Name = "lblSteam";
            this.lblSteam.Size = new System.Drawing.Size(37, 13);
            this.lblSteam.TabIndex = 0;
            this.lblSteam.Text = "Steam";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::IdleMaster.Properties.Resources.Refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(82, 79);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Location = new System.Drawing.Point(12, 47);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(64, 64);
            this.ptbAvatar.TabIndex = 5;
            this.ptbAvatar.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(79, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lsvBadges
            // 
            this.lsvBadges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGame,
            this.colHoursPlayed,
            this.colRemainingCards,
            this.colStatus});
            this.lsvBadges.FullRowSelect = true;
            this.lsvBadges.GridLines = true;
            this.lsvBadges.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvBadges.HideSelection = false;
            this.lsvBadges.Location = new System.Drawing.Point(12, 117);
            this.lsvBadges.MultiSelect = false;
            this.lsvBadges.Name = "lsvBadges";
            this.lsvBadges.Size = new System.Drawing.Size(431, 197);
            this.lsvBadges.TabIndex = 7;
            this.lsvBadges.UseCompatibleStateImageBehavior = false;
            this.lsvBadges.View = System.Windows.Forms.View.Details;
            this.lsvBadges.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsvBadges_ColumnWidthChanging);
            this.lsvBadges.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvBadges_ItemSelectionChanged);
            this.lsvBadges.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvBadges_KeyDown);
            // 
            // colGame
            // 
            this.colGame.Text = "Game";
            this.colGame.Width = 150;
            // 
            // colHoursPlayed
            // 
            this.colHoursPlayed.Text = "Hours Played";
            this.colHoursPlayed.Width = 100;
            // 
            // colRemainingCards
            // 
            this.colRemainingCards.Text = "Remaining Cards";
            this.colRemainingCards.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // tmrNormalIdleStatus
            // 
            this.tmrNormalIdleStatus.Interval = 60000;
            this.tmrNormalIdleStatus.Tick += new System.EventHandler(this.tmrNormalIdleStatus_Tick);
            // 
            // tmrFastIdleStart
            // 
            this.tmrFastIdleStart.Interval = 5000;
            this.tmrFastIdleStart.Tick += new System.EventHandler(this.tmrFastIdleStart_Tick);
            // 
            // tmrFastIdleStop
            // 
            this.tmrFastIdleStop.Interval = 10000;
            this.tmrFastIdleStop.Tick += new System.EventHandler(this.tmrFastIdleStop_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 326);
            this.Controls.Add(this.lsvBadges);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSteam);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lnkSession);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idle Master";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSteamStatus;
        private System.Windows.Forms.LinkLabel lnkSession;
        private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblSteam;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ListView lsvBadges;
        private System.Windows.Forms.ColumnHeader colGame;
        private System.Windows.Forms.ColumnHeader colHoursPlayed;
        private System.Windows.Forms.ColumnHeader colRemainingCards;
        private System.Windows.Forms.Timer tmrNormalIdleStatus;
        private System.Windows.Forms.Timer tmrFastIdleStart;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Timer tmrFastIdleStop;
    }
}