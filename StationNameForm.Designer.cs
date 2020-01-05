namespace Blechelse
{
    partial class StationNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationNameForm));
            this.lbStationNames = new System.Windows.Forms.ListBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.gbIntonation = new System.Windows.Forms.GroupBox();
            this.rbIntonationLow = new System.Windows.Forms.RadioButton();
            this.rbIntonationHigh = new System.Windows.Forms.RadioButton();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.rbShortName = new System.Windows.Forms.RadioButton();
            this.rbFullName = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbIntonation.SuspendLayout();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStationNames
            // 
            this.lbStationNames.FormattingEnabled = true;
            this.lbStationNames.HorizontalScrollbar = true;
            this.lbStationNames.Location = new System.Drawing.Point(12, 38);
            this.lbStationNames.Name = "lbStationNames";
            this.lbStationNames.Size = new System.Drawing.Size(260, 212);
            this.lbStationNames.TabIndex = 0;
            this.lbStationNames.DoubleClick += new System.EventHandler(this.lbStationNames_DoubleClick);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(260, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // gbIntonation
            // 
            this.gbIntonation.Controls.Add(this.rbIntonationLow);
            this.gbIntonation.Controls.Add(this.rbIntonationHigh);
            this.gbIntonation.Location = new System.Drawing.Point(12, 256);
            this.gbIntonation.Name = "gbIntonation";
            this.gbIntonation.Size = new System.Drawing.Size(260, 44);
            this.gbIntonation.TabIndex = 2;
            this.gbIntonation.TabStop = false;
            this.gbIntonation.Text = "Intonation";
            // 
            // rbIntonationLow
            // 
            this.rbIntonationLow.AutoSize = true;
            this.rbIntonationLow.Location = new System.Drawing.Point(84, 19);
            this.rbIntonationLow.Name = "rbIntonationLow";
            this.rbIntonationLow.Size = new System.Drawing.Size(45, 17);
            this.rbIntonationLow.TabIndex = 1;
            this.rbIntonationLow.Text = "Low";
            this.rbIntonationLow.UseVisualStyleBackColor = true;
            // 
            // rbIntonationHigh
            // 
            this.rbIntonationHigh.AutoSize = true;
            this.rbIntonationHigh.Checked = true;
            this.rbIntonationHigh.Location = new System.Drawing.Point(6, 19);
            this.rbIntonationHigh.Name = "rbIntonationHigh";
            this.rbIntonationHigh.Size = new System.Drawing.Size(47, 17);
            this.rbIntonationHigh.TabIndex = 0;
            this.rbIntonationHigh.TabStop = true;
            this.rbIntonationHigh.Text = "High";
            this.rbIntonationHigh.UseVisualStyleBackColor = true;
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.rbShortName);
            this.gbName.Controls.Add(this.rbFullName);
            this.gbName.Location = new System.Drawing.Point(12, 306);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(260, 44);
            this.gbName.TabIndex = 3;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name";
            // 
            // rbShortName
            // 
            this.rbShortName.AutoSize = true;
            this.rbShortName.Location = new System.Drawing.Point(84, 19);
            this.rbShortName.Name = "rbShortName";
            this.rbShortName.Size = new System.Drawing.Size(81, 17);
            this.rbShortName.TabIndex = 1;
            this.rbShortName.Text = "Short Name";
            this.rbShortName.UseVisualStyleBackColor = true;
            // 
            // rbFullName
            // 
            this.rbFullName.AutoSize = true;
            this.rbFullName.Checked = true;
            this.rbFullName.Location = new System.Drawing.Point(6, 19);
            this.rbFullName.Name = "rbFullName";
            this.rbFullName.Size = new System.Drawing.Size(72, 17);
            this.rbFullName.TabIndex = 0;
            this.rbFullName.TabStop = true;
            this.rbFullName.Text = "Full Name";
            this.rbFullName.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 356);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StationNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 390);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.gbIntonation);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lbStationNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StationNameForm";
            this.Text = "Station Name";
            this.gbIntonation.ResumeLayout(false);
            this.gbIntonation.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStationNames;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.GroupBox gbIntonation;
        private System.Windows.Forms.RadioButton rbIntonationLow;
        private System.Windows.Forms.RadioButton rbIntonationHigh;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.RadioButton rbShortName;
        private System.Windows.Forms.RadioButton rbFullName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}