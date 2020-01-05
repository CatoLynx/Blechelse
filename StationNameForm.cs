using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Blechelse
{
    public partial class StationNameForm : Form
    {
        Backend backend;
        List<t_DatabaseRecord> stationNames;
        List<t_DatabaseRecord> filteredStationNames = new List<t_DatabaseRecord>();
        public VoiceSnippet SelectedStation = new VoiceSnippet();

        public StationNameForm(Backend backend)
        {
            InitializeComponent();
            this.backend = backend;
            stationNames = backend.GetStationNames();
            filterStations("");
            ActiveControl = txtFilter;
        }

        // GUI CALLBACKS

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            filterStations(txtFilter.Text);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            confirmSelection();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbStationNames_DoubleClick(object sender, EventArgs e)
        {
            if (lbStationNames.SelectedIndex == -1) return;
            confirmSelection();
        }

        // HELPER FUNCTIONS

        private void filterStations(string text)
        {
            text = text.ToLower();
            filteredStationNames.Clear();
            lbStationNames.BeginUpdate();
            lbStationNames.Items.Clear();
            foreach(t_DatabaseRecord record in stationNames)
            {
                if(record.StationName.ToLower().Contains(text))
                {
                    lbStationNames.Items.Add(record.StationName);
                    filteredStationNames.Add(record);
                }
            }
            lbStationNames.EndUpdate();
        }

        private void confirmSelection()
        {
            if (lbStationNames.SelectedIndex != -1)
            {
                t_DatabaseRecord station = filteredStationNames[lbStationNames.SelectedIndex];
                SelectedStation = new VoiceSnippet
                {
                    FileName = Path.Combine("ziele", rbFullName.Checked ? "variante2" : "variante1", rbIntonationHigh.Checked ? "hoch" : "tief", station.FileName),
                    DisplayText = rbFullName.Checked ? station.ContentLong : station.ContentShort,
                    HasValue = true
                };
            }
            Close();
        }
    }
}
