using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Blechelse
{
    public partial class MainForm : Form
    {
        Backend backend;
        Thread soundThread;
        bool soundEnabled = false;
        string audioDir;

        public MainForm()
        {
            InitializeComponent();
            IniFile config = new IniFile("blechelse.ini");
            string dbFile = config.Read("DatabaseFile", "Paths");
            audioDir = config.Read("AudioDir", "Paths");
            backend = new Backend(dbFile);
            updateButtonEnableStates();
        }

        // GUI CALLBACKS
        
        private void lbVoiceSnippets_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateButtonEnableStates();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmAddType.Show(btnAdd, new Point(0, btnAdd.Height));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbVoiceSnippets.SelectedIndex == -1) return;
            int oldIndex = lbVoiceSnippets.SelectedIndex;
            lbVoiceSnippets.Items.RemoveAt(oldIndex);
            if (lbVoiceSnippets.Items.Count > 0)
            {
                if (oldIndex >= lbVoiceSnippets.Items.Count) oldIndex -= 1;
                lbVoiceSnippets.SetSelected(oldIndex, true);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lbVoiceSnippets.Items.Clear();
            updateButtonEnableStates();
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            moveVoiceSnippet(-1);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            moveVoiceSnippet(1);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (soundThread != null && soundThread.IsAlive) return;
            soundThread = new Thread(new ThreadStart(playSound));
            soundEnabled = true;
            soundThread.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            soundEnabled = false;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult result = sfdOutputFile.ShowDialog();
            if (result != DialogResult.OK) return;
            List<string> inputFiles = new List<string>();
            foreach(VoiceSnippet snippet in lbVoiceSnippets.Items)
            {
                inputFiles.Add(addBaseDir(snippet.FileName));
            }
            ConcatenateWAV(sfdOutputFile.FileName, inputFiles);
            MessageBox.Show("Announcement successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            soundEnabled = false;
        }

        private void miIntermediateBlockNewStyle_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("intermediate_blocks_new", "module_3_1", false);
        }

        private void miIntermediateBlockOldStyle_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("intermediate_blocks_old", "module", false);
        }

        private void miPlatformTrainNumber_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("platform_numbers", "gleise_zahlen", true);
        }

        private void miPlatformSection_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("platform_sections", "abschnitte", true);
        }

        private void miHour_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("hours", "zeiten/stunden", true);
        }

        private void miMinute_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("minutes", "zeiten/minuten", true);
        }

        private void miStationName_Click(object sender, EventArgs e)
        {
            StationNameForm f = new StationNameForm(backend);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
            VoiceSnippet result = f.SelectedStation;
            if (result.HasValue)
            {
                addVoiceSnippet(result);
                updateButtonEnableStates();
            }
        }

        private void miDelayNewStyleNeutral_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("delays_new_neutral", "zeiten/verspaetung_heute", false);
        }

        private void miDelayOldStyleDeparture_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("delays_old_departure", "zeiten/verspaetung_ab", false);
        }

        private void miOldStyleArrival_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("delays_old_arrival", "zeiten/verspaetung_an", false);
        }

        private void miDelayReasonNewStyle_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("delay_reasons_new", "gruende/grund_dafuer", false);
        }

        private void miDelayReasonOldStyle_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("delay_reasons_old", "gruende", true);
        }

        private void miTrainType_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("train_types", "zuggattungen", true);
        }

        private void miLineNumberSBahn_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("line_numbers_sbahn", "linien/s_linien_nr", true);
        }

        private void miLineNumberOtherPrefixes_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("line_number_prefixes", "linien/linien_kombi", false);
        }

        private void miGeneralAnnouncement_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("general_announcements", "nza", false);
        }

        private void miAdditionalBlock_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("additional_blocks", "zusatztexte", false);
        }

        private void miGong_Click(object sender, EventArgs e)
        {
            genericVoiceSnippetAddHandler("gongs", "../gong", false);
        }

        // HELPER FUNCTIONS

        private void genericVoiceSnippetAddHandler(string dbTable, string baseDir, bool hasIntonation)
        {
            GenericVoiceSnippetForm f = new GenericVoiceSnippetForm(backend, dbTable, baseDir, hasIntonation);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
            VoiceSnippet result = f.SelectedSnippet;
            if (result.HasValue)
            {
                addVoiceSnippet(result);
                updateButtonEnableStates();
            }
        }

        private string addBaseDir(string filename)
        {
            string baseDir = "";
            if (rbLangGerman.Checked)
            {
                baseDir = "dt";
            }
            else if (rbLangEnglish.Checked)
            {
                baseDir = "en";
            }
            else if (rbLangFrench.Checked)
            {
                baseDir = "fr";
            }
            return Path.Combine(audioDir, baseDir, filename);
        }

        private void playSound()
        {
            try
            {
                foreach (VoiceSnippet snippet in lbVoiceSnippets.Items)
                {
                    if (soundEnabled == false) return;
                    string filename = addBaseDir(snippet.FileName);
                    SoundPlayer player = new SoundPlayer(filename);
                    player.PlaySync();
                }
            }
            catch (Exception e)
            {

            }
            soundEnabled = false;
        }

        private void addVoiceSnippet(VoiceSnippet snippet)
        {
            lbVoiceSnippets.Items.Add(snippet);
        }

        private void updateButtonEnableStates()
        {
            if(lbVoiceSnippets.Items.Count == 0)
            {
                btnRemove.Enabled = false;
                btnMoveUp.Enabled = false;
                btnMoveDown.Enabled = false;
                btnPlay.Enabled = false;
                btnStop.Enabled = false;
                btnSaveAs.Enabled = false;
            }
            else
            {
                btnPlay.Enabled = true;
                btnStop.Enabled = true;
                btnSaveAs.Enabled = true;

                if (lbVoiceSnippets.SelectedIndex != -1)
                {
                    btnRemove.Enabled = true;

                    if (lbVoiceSnippets.SelectedIndex > 0)
                    {
                        btnMoveUp.Enabled = true;
                    }
                    else
                    {
                        btnMoveUp.Enabled = false;
                    }

                    if (lbVoiceSnippets.SelectedIndex < lbVoiceSnippets.Items.Count - 1)
                    {
                        btnMoveDown.Enabled = true;
                    }
                    else
                    {
                        btnMoveDown.Enabled = false;
                    }
                }
                else
                {
                    btnRemove.Enabled = false;
                    btnMoveUp.Enabled = false;
                    btnMoveDown.Enabled = false;
                }
            }
        }

        private void moveVoiceSnippet(int direction)
        {
            // Checking selected item
            if (lbVoiceSnippets.SelectedItem == null || lbVoiceSnippets.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = lbVoiceSnippets.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lbVoiceSnippets.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lbVoiceSnippets.SelectedItem;

            // Removing removable element
            lbVoiceSnippets.Items.Remove(selected);
            // Insert it in new position
            lbVoiceSnippets.Items.Insert(newIndex, selected);
            // Restore selection
            lbVoiceSnippets.SetSelected(newIndex, true);
        }

        private void ConcatenateWAV(string outputFile, IEnumerable<string> sourceFiles)
        {
            byte[] buffer = new byte[1024];
            WaveFileWriter waveFileWriter = null;

            try
            {
                foreach (string sourceFile in sourceFiles)
                {
                    using (WaveFileReader reader = new WaveFileReader(sourceFile))
                    {
                        if (waveFileWriter == null)
                        {
                            // first time in create new Writer
                            waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
                        }
                        else
                        {
                            if (!reader.WaveFormat.Equals(waveFileWriter.WaveFormat))
                            {
                                throw new InvalidOperationException("Can't concatenate WAV Files that don't share the same format");
                            }
                        }

                        int read;
                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            waveFileWriter.Write(buffer, 0, read);
                        }
                    }
                }
            }
            finally
            {
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                }
            }

        }
    }
}
