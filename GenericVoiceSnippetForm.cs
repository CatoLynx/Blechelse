using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Blechelse
{
    public partial class GenericVoiceSnippetForm : Form
    {
        Backend backend;
        string baseDir;
        bool hasIntonation;
        List<t_DatabaseRecord> voiceSnippets;
        List<t_DatabaseRecord> filteredVoiceSnippets = new List<t_DatabaseRecord>();
        public VoiceSnippet SelectedSnippet = new VoiceSnippet();
        public MainForm parentForm;

        public GenericVoiceSnippetForm(Backend backend, string tableName, string baseDir, bool hasIntonation)
        {
            InitializeComponent();
            this.backend = backend;
            this.baseDir = baseDir;
            this.hasIntonation = hasIntonation;
            voiceSnippets = backend.GetVoiceSnippets(tableName);
            filterSnippets("");
            if(!hasIntonation)
            {
                gbIntonation.Enabled = false;
            }
            ActiveControl = txtFilter;
        }

        // GUI CALLBACKS

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            filterSnippets(txtFilter.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            confirmSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbVoiceSnippets_DoubleClick(object sender, EventArgs e)
        {
            if (lbVoiceSnippets.SelectedIndex == -1) return;
            confirmSelection();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (lbVoiceSnippets.SelectedIndex != -1)
            {
                t_DatabaseRecord snippet = filteredVoiceSnippets[lbVoiceSnippets.SelectedIndex];
                if (hasIntonation)
                {
                    VoiceSnippet vSnippet = new VoiceSnippet
                    {
                        FileName = Path.Combine(baseDir, rbIntonationHigh.Checked ? "hoch" : "tief", snippet.FileName),
                        DisplayText = snippet.ContentLong,
                        HasValue = true
                    };

                    string filename = parentForm.addBaseDir(vSnippet.FileName);
                    SoundPlayer player = new SoundPlayer(filename);
                    player.PlaySync();
                }
                else
                {
                    VoiceSnippet vSnippet = new VoiceSnippet
                    {
                        FileName = Path.Combine(baseDir, snippet.FileName),
                        DisplayText = snippet.ContentLong,
                        HasValue = true
                    };

                    string filename = parentForm.addBaseDir(vSnippet.FileName);
                    SoundPlayer player = new SoundPlayer(filename);
                    player.PlaySync();
                }
            }
        }

        // HELPER FUNCTIONS

        private void filterSnippets(string text)
        {
            text = text.ToLower();
            filteredVoiceSnippets.Clear();
            lbVoiceSnippets.BeginUpdate();
            lbVoiceSnippets.Items.Clear();
            foreach (t_DatabaseRecord record in voiceSnippets)
            {
                if (record.ContentShort.ToLower().Contains(text))
                {
                    lbVoiceSnippets.Items.Add(record.ContentShort);
                    filteredVoiceSnippets.Add(record);
                }
            }
            lbVoiceSnippets.EndUpdate();
        }

        private void confirmSelection()
        {
            if (lbVoiceSnippets.SelectedIndex != -1)
            {
                t_DatabaseRecord snippet = filteredVoiceSnippets[lbVoiceSnippets.SelectedIndex];
                if (hasIntonation)
                {
                    SelectedSnippet = new VoiceSnippet
                    {
                        FileName = Path.Combine(baseDir, rbIntonationHigh.Checked ? "hoch" : "tief", snippet.FileName),
                        DisplayText = snippet.ContentLong,
                        HasValue = true
                    };
                }
                else
                {
                    SelectedSnippet = new VoiceSnippet
                    {
                        FileName = Path.Combine(baseDir, snippet.FileName),
                        DisplayText = snippet.ContentLong,
                        HasValue = true
                    };
                }
            }
            Close();
        }
    }
}
