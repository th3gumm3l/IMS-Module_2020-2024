using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    public partial class StationForm : Form
    {
        public StationForm(StartseiteForm startseiteForm)
        {
            InitializeComponent();
            StartseiteForm = startseiteForm;
        }

        ITransport transport = new Transport();

        public StartseiteForm StartseiteForm { get; }

        private void StationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartseiteForm.Show();
        }

        private void sMainSearch_btn_Click(object sender, EventArgs e)
        {
            try
            {
                sSuchanzeigen_dgv.Rows.Clear();
                var stationBoard = transport.GetStationBoard(sStationsuchen_cbx.Text, sStationsuchen_cbx.Text);
                foreach (StationBoard stationBoardItem in stationBoard.Entries)
                {
                    sSuchanzeigen_dgv.Rows.Add(

                        stationBoardItem.To,
                        stationBoardItem.Stop.Departure
                        );
                }
            }

            catch
            {
                MessageBox.Show("Keine Internetverbindung");
            }

        }

        private void Autosuggestions(ComboBox comboBoxObjekt)
        {
            try
            {
                comboBoxObjekt.Items.Clear();
                comboBoxObjekt.SelectionStart = comboBoxObjekt.Text.Length + 1;

                var stations = transport.GetStations(comboBoxObjekt.Text);

                foreach (Station stationItem in stations.StationList)
                {
                    comboBoxObjekt.Items.Add(stationItem.Name);
                }
            }

            catch
            {
                comboBoxObjekt.Items.Clear();
                comboBoxObjekt.SelectionStart = comboBoxObjekt.Text.Length + 1;
                comboBoxObjekt.Items.Add("Keine Ergebnisse");
            }

        }

        private void sStationsuchen_cbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Autosuggestions(sStationsuchen_cbx);
            }
        }

        private void sStationsuchen_cbx_Enter(object sender, EventArgs e)
        {
            sStationsuchen_cbx.DroppedDown = true;
        }

        private void sStationsuchen_cbx_Leave(object sender, EventArgs e)
        {
            sStationsuchen_cbx.DroppedDown = false;
        }

    }
}
