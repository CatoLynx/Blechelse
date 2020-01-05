namespace Blechelse
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbVoiceSnippets = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.cmAddType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miIntermediateBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.miIntermediateBlockNewStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.miIntermediateBlockOldStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.miPlatformTrainNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.miPlatformSection = new System.Windows.Forms.ToolStripMenuItem();
            this.miHour = new System.Windows.Forms.ToolStripMenuItem();
            this.miMinute = new System.Windows.Forms.ToolStripMenuItem();
            this.miStationName = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelay = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelayNewStyleNeutral = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelayOldStyleDeparture = new System.Windows.Forms.ToolStripMenuItem();
            this.miOldStyleArrival = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelayReason = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelayReasonNewStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelayReasonOldStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrainType = new System.Windows.Forms.ToolStripMenuItem();
            this.miLineNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.miLineNumberSBahn = new System.Windows.Forms.ToolStripMenuItem();
            this.miLineNumberOtherPrefixes = new System.Windows.Forms.ToolStripMenuItem();
            this.miGeneralAnnouncement = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdditionalBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.miGong = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.rbLangFrench = new System.Windows.Forms.RadioButton();
            this.rbLangEnglish = new System.Windows.Forms.RadioButton();
            this.rbLangGerman = new System.Windows.Forms.RadioButton();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.sfdOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.cmAddType.SuspendLayout();
            this.gbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbVoiceSnippets
            // 
            this.lbVoiceSnippets.FormattingEnabled = true;
            this.lbVoiceSnippets.HorizontalScrollbar = true;
            this.lbVoiceSnippets.Location = new System.Drawing.Point(12, 12);
            this.lbVoiceSnippets.Name = "lbVoiceSnippets";
            this.lbVoiceSnippets.Size = new System.Drawing.Size(625, 329);
            this.lbVoiceSnippets.TabIndex = 0;
            this.lbVoiceSnippets.SelectedIndexChanged += new System.EventHandler(this.lbVoiceSnippets_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(93, 347);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(255, 347);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.Text = "Move up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(336, 347);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.Text = "Move down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(417, 347);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(529, 347);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 6;
            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // cmAddType
            // 
            this.cmAddType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIntermediateBlock,
            this.miPlatformTrainNumber,
            this.miPlatformSection,
            this.miHour,
            this.miMinute,
            this.miStationName,
            this.miDelay,
            this.miDelayReason,
            this.miTrainType,
            this.miLineNumber,
            this.miGeneralAnnouncement,
            this.miAdditionalBlock,
            this.miGong});
            this.cmAddType.Name = "cmAddType";
            this.cmAddType.Size = new System.Drawing.Size(204, 290);
            // 
            // miIntermediateBlock
            // 
            this.miIntermediateBlock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIntermediateBlockNewStyle,
            this.miIntermediateBlockOldStyle});
            this.miIntermediateBlock.Name = "miIntermediateBlock";
            this.miIntermediateBlock.Size = new System.Drawing.Size(203, 22);
            this.miIntermediateBlock.Text = "Intermediate Block";
            // 
            // miIntermediateBlockNewStyle
            // 
            this.miIntermediateBlockNewStyle.Name = "miIntermediateBlockNewStyle";
            this.miIntermediateBlockNewStyle.Size = new System.Drawing.Size(126, 22);
            this.miIntermediateBlockNewStyle.Text = "New Style";
            this.miIntermediateBlockNewStyle.Click += new System.EventHandler(this.miIntermediateBlockNewStyle_Click);
            // 
            // miIntermediateBlockOldStyle
            // 
            this.miIntermediateBlockOldStyle.Name = "miIntermediateBlockOldStyle";
            this.miIntermediateBlockOldStyle.Size = new System.Drawing.Size(126, 22);
            this.miIntermediateBlockOldStyle.Text = "Old Style";
            this.miIntermediateBlockOldStyle.Click += new System.EventHandler(this.miIntermediateBlockOldStyle_Click);
            // 
            // miPlatformTrainNumber
            // 
            this.miPlatformTrainNumber.Name = "miPlatformTrainNumber";
            this.miPlatformTrainNumber.Size = new System.Drawing.Size(203, 22);
            this.miPlatformTrainNumber.Text = "Platform / Train Number";
            this.miPlatformTrainNumber.Click += new System.EventHandler(this.miPlatformTrainNumber_Click);
            // 
            // miPlatformSection
            // 
            this.miPlatformSection.Name = "miPlatformSection";
            this.miPlatformSection.Size = new System.Drawing.Size(203, 22);
            this.miPlatformSection.Text = "Platform Section";
            this.miPlatformSection.Click += new System.EventHandler(this.miPlatformSection_Click);
            // 
            // miHour
            // 
            this.miHour.Name = "miHour";
            this.miHour.Size = new System.Drawing.Size(203, 22);
            this.miHour.Text = "Hour";
            this.miHour.Click += new System.EventHandler(this.miHour_Click);
            // 
            // miMinute
            // 
            this.miMinute.Name = "miMinute";
            this.miMinute.Size = new System.Drawing.Size(203, 22);
            this.miMinute.Text = "Minute";
            this.miMinute.Click += new System.EventHandler(this.miMinute_Click);
            // 
            // miStationName
            // 
            this.miStationName.Name = "miStationName";
            this.miStationName.Size = new System.Drawing.Size(203, 22);
            this.miStationName.Text = "Station Name";
            this.miStationName.Click += new System.EventHandler(this.miStationName_Click);
            // 
            // miDelay
            // 
            this.miDelay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDelayNewStyleNeutral,
            this.miDelayOldStyleDeparture,
            this.miOldStyleArrival});
            this.miDelay.Name = "miDelay";
            this.miDelay.Size = new System.Drawing.Size(203, 22);
            this.miDelay.Text = "Delay";
            // 
            // miDelayNewStyleNeutral
            // 
            this.miDelayNewStyleNeutral.Name = "miDelayNewStyleNeutral";
            this.miDelayNewStyleNeutral.Size = new System.Drawing.Size(184, 22);
            this.miDelayNewStyleNeutral.Text = "New Style (Neutral)";
            this.miDelayNewStyleNeutral.Click += new System.EventHandler(this.miDelayNewStyleNeutral_Click);
            // 
            // miDelayOldStyleDeparture
            // 
            this.miDelayOldStyleDeparture.Name = "miDelayOldStyleDeparture";
            this.miDelayOldStyleDeparture.Size = new System.Drawing.Size(184, 22);
            this.miDelayOldStyleDeparture.Text = "Old Style (Departure)";
            this.miDelayOldStyleDeparture.Click += new System.EventHandler(this.miDelayOldStyleDeparture_Click);
            // 
            // miOldStyleArrival
            // 
            this.miOldStyleArrival.Name = "miOldStyleArrival";
            this.miOldStyleArrival.Size = new System.Drawing.Size(184, 22);
            this.miOldStyleArrival.Text = "Old Style (Arrival)";
            this.miOldStyleArrival.Click += new System.EventHandler(this.miOldStyleArrival_Click);
            // 
            // miDelayReason
            // 
            this.miDelayReason.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDelayReasonNewStyle,
            this.miDelayReasonOldStyle});
            this.miDelayReason.Name = "miDelayReason";
            this.miDelayReason.Size = new System.Drawing.Size(203, 22);
            this.miDelayReason.Text = "Delay Reason";
            // 
            // miDelayReasonNewStyle
            // 
            this.miDelayReasonNewStyle.Name = "miDelayReasonNewStyle";
            this.miDelayReasonNewStyle.Size = new System.Drawing.Size(126, 22);
            this.miDelayReasonNewStyle.Text = "New Style";
            this.miDelayReasonNewStyle.Click += new System.EventHandler(this.miDelayReasonNewStyle_Click);
            // 
            // miDelayReasonOldStyle
            // 
            this.miDelayReasonOldStyle.Name = "miDelayReasonOldStyle";
            this.miDelayReasonOldStyle.Size = new System.Drawing.Size(126, 22);
            this.miDelayReasonOldStyle.Text = "Old Style";
            this.miDelayReasonOldStyle.Click += new System.EventHandler(this.miDelayReasonOldStyle_Click);
            // 
            // miTrainType
            // 
            this.miTrainType.Name = "miTrainType";
            this.miTrainType.Size = new System.Drawing.Size(203, 22);
            this.miTrainType.Text = "Train Type";
            this.miTrainType.Click += new System.EventHandler(this.miTrainType_Click);
            // 
            // miLineNumber
            // 
            this.miLineNumber.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLineNumberSBahn,
            this.miLineNumberOtherPrefixes});
            this.miLineNumber.Name = "miLineNumber";
            this.miLineNumber.Size = new System.Drawing.Size(203, 22);
            this.miLineNumber.Text = "Line Number";
            // 
            // miLineNumberSBahn
            // 
            this.miLineNumberSBahn.Name = "miLineNumberSBahn";
            this.miLineNumberSBahn.Size = new System.Drawing.Size(148, 22);
            this.miLineNumberSBahn.Text = "S-Bahn";
            this.miLineNumberSBahn.Click += new System.EventHandler(this.miLineNumberSBahn_Click);
            // 
            // miLineNumberOtherPrefixes
            // 
            this.miLineNumberOtherPrefixes.Name = "miLineNumberOtherPrefixes";
            this.miLineNumberOtherPrefixes.Size = new System.Drawing.Size(148, 22);
            this.miLineNumberOtherPrefixes.Text = "Other Prefixes";
            this.miLineNumberOtherPrefixes.Click += new System.EventHandler(this.miLineNumberOtherPrefixes_Click);
            // 
            // miGeneralAnnouncement
            // 
            this.miGeneralAnnouncement.Name = "miGeneralAnnouncement";
            this.miGeneralAnnouncement.Size = new System.Drawing.Size(203, 22);
            this.miGeneralAnnouncement.Text = "General Announcement";
            this.miGeneralAnnouncement.Click += new System.EventHandler(this.miGeneralAnnouncement_Click);
            // 
            // miAdditionalBlock
            // 
            this.miAdditionalBlock.Name = "miAdditionalBlock";
            this.miAdditionalBlock.Size = new System.Drawing.Size(203, 22);
            this.miAdditionalBlock.Text = "Additional Block";
            this.miAdditionalBlock.Click += new System.EventHandler(this.miAdditionalBlock_Click);
            // 
            // miGong
            // 
            this.miGong.Name = "miGong";
            this.miGong.Size = new System.Drawing.Size(203, 22);
            this.miGong.Text = "Gong";
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.rbLangFrench);
            this.gbLanguage.Controls.Add(this.rbLangEnglish);
            this.gbLanguage.Controls.Add(this.rbLangGerman);
            this.gbLanguage.Location = new System.Drawing.Point(12, 376);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(200, 45);
            this.gbLanguage.TabIndex = 8;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Language";
            // 
            // rbLangFrench
            // 
            this.rbLangFrench.AutoSize = true;
            this.rbLangFrench.Location = new System.Drawing.Point(139, 19);
            this.rbLangFrench.Name = "rbLangFrench";
            this.rbLangFrench.Size = new System.Drawing.Size(58, 17);
            this.rbLangFrench.TabIndex = 9;
            this.rbLangFrench.Text = "French";
            this.rbLangFrench.UseVisualStyleBackColor = true;
            // 
            // rbLangEnglish
            // 
            this.rbLangEnglish.AutoSize = true;
            this.rbLangEnglish.Location = new System.Drawing.Point(74, 19);
            this.rbLangEnglish.Name = "rbLangEnglish";
            this.rbLangEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbLangEnglish.TabIndex = 9;
            this.rbLangEnglish.Text = "English";
            this.rbLangEnglish.UseVisualStyleBackColor = true;
            // 
            // rbLangGerman
            // 
            this.rbLangGerman.AutoSize = true;
            this.rbLangGerman.Checked = true;
            this.rbLangGerman.Location = new System.Drawing.Point(6, 19);
            this.rbLangGerman.Name = "rbLangGerman";
            this.rbLangGerman.Size = new System.Drawing.Size(62, 17);
            this.rbLangGerman.TabIndex = 9;
            this.rbLangGerman.TabStop = true;
            this.rbLangGerman.Text = "German";
            this.rbLangGerman.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(174, 347);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 9;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(473, 347);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // sfdOutputFile
            // 
            this.sfdOutputFile.DefaultExt = "wav";
            this.sfdOutputFile.Filter = "Wave Files|*.wav";
            this.sfdOutputFile.RestoreDirectory = true;
            this.sfdOutputFile.Title = "Save Announcement";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 432);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbVoiceSnippets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Blechelse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.cmAddType.ResumeLayout(false);
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbVoiceSnippets;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.ContextMenuStrip cmAddType;
        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.RadioButton rbLangFrench;
        private System.Windows.Forms.RadioButton rbLangEnglish;
        private System.Windows.Forms.RadioButton rbLangGerman;
        private System.Windows.Forms.ToolStripMenuItem miIntermediateBlock;
        private System.Windows.Forms.ToolStripMenuItem miIntermediateBlockNewStyle;
        private System.Windows.Forms.ToolStripMenuItem miIntermediateBlockOldStyle;
        private System.Windows.Forms.ToolStripMenuItem miPlatformTrainNumber;
        private System.Windows.Forms.ToolStripMenuItem miPlatformSection;
        private System.Windows.Forms.ToolStripMenuItem miHour;
        private System.Windows.Forms.ToolStripMenuItem miStationName;
        private System.Windows.Forms.ToolStripMenuItem miDelay;
        private System.Windows.Forms.ToolStripMenuItem miDelayNewStyleNeutral;
        private System.Windows.Forms.ToolStripMenuItem miDelayOldStyleDeparture;
        private System.Windows.Forms.ToolStripMenuItem miOldStyleArrival;
        private System.Windows.Forms.ToolStripMenuItem miDelayReason;
        private System.Windows.Forms.ToolStripMenuItem miDelayReasonNewStyle;
        private System.Windows.Forms.ToolStripMenuItem miDelayReasonOldStyle;
        private System.Windows.Forms.ToolStripMenuItem miTrainType;
        private System.Windows.Forms.ToolStripMenuItem miLineNumber;
        private System.Windows.Forms.ToolStripMenuItem miLineNumberSBahn;
        private System.Windows.Forms.ToolStripMenuItem miLineNumberOtherPrefixes;
        private System.Windows.Forms.ToolStripMenuItem miGeneralAnnouncement;
        private System.Windows.Forms.ToolStripMenuItem miAdditionalBlock;
        private System.Windows.Forms.ToolStripMenuItem miGong;
        private System.Windows.Forms.ToolStripMenuItem miMinute;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.SaveFileDialog sfdOutputFile;
    }
}

