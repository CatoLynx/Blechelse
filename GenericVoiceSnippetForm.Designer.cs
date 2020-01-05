namespace Blechelse
{
    partial class GenericVoiceSnippetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenericVoiceSnippetForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lbVoiceSnippets = new System.Windows.Forms.ListBox();
            this.gbIntonation = new System.Windows.Forms.GroupBox();
            this.rbIntonationLow = new System.Windows.Forms.RadioButton();
            this.rbIntonationHigh = new System.Windows.Forms.RadioButton();
            this.gbIntonation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(260, 20);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lbVoiceSnippets
            // 
            this.lbVoiceSnippets.FormattingEnabled = true;
            this.lbVoiceSnippets.HorizontalScrollbar = true;
            this.lbVoiceSnippets.Location = new System.Drawing.Point(12, 38);
            this.lbVoiceSnippets.Name = "lbVoiceSnippets";
            this.lbVoiceSnippets.Size = new System.Drawing.Size(260, 212);
            this.lbVoiceSnippets.TabIndex = 6;
            this.lbVoiceSnippets.DoubleClick += new System.EventHandler(this.lbVoiceSnippets_DoubleClick);
            // 
            // gbIntonation
            // 
            this.gbIntonation.Controls.Add(this.rbIntonationLow);
            this.gbIntonation.Controls.Add(this.rbIntonationHigh);
            this.gbIntonation.Location = new System.Drawing.Point(12, 256);
            this.gbIntonation.Name = "gbIntonation";
            this.gbIntonation.Size = new System.Drawing.Size(260, 44);
            this.gbIntonation.TabIndex = 10;
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
            // GenericVoiceSnippetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 339);
            this.Controls.Add(this.gbIntonation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lbVoiceSnippets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GenericVoiceSnippetForm";
            this.Text = "Voice Snippet";
            this.gbIntonation.ResumeLayout(false);
            this.gbIntonation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ListBox lbVoiceSnippets;
        private System.Windows.Forms.GroupBox gbIntonation;
        private System.Windows.Forms.RadioButton rbIntonationLow;
        private System.Windows.Forms.RadioButton rbIntonationHigh;
    }
}