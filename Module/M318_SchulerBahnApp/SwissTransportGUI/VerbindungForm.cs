using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using SwissTransport.Core;
using SwissTransport.Models;
using System.Net.Mail;

namespace SwissTransportGUI
{
    public partial class VerbindungForm : Form
    {
        public VerbindungForm(StartseiteForm startseiteForm)
        {
            InitializeComponent();
            StartseiteForm = startseiteForm;
        }

        ITransport transport = new Transport();
        
        public StartseiteForm StartseiteForm { get; }

        private void vMainSearch_btn_Click(object sender, EventArgs e)
        {
            try
            {
                vSuchanzeigen_dgv.Rows.Clear();

                var connectionsListe = transport.GetConnections(vSearchAbfahrtsOrt_cbx.Text, vSearchAnkunftsOrt_cbx.Text, datePicker.Value, timePicker.Value);

                foreach (Connection connectionItem in connectionsListe.ConnectionList)
                {
                    vSuchanzeigen_dgv.Rows.Add(
                        connectionItem.From.Station.Name + "\n" + connectionItem.From.Departure,
                        connectionItem.To.Station.Name + "\n" + connectionItem.To.Arrival,
                        connectionItem.Duration,
                        connectionItem.From.Platform
                        );
                }
            }

            catch
            {

                MessageBox.Show("Keine Internetverbindung");
            }
        }

        private void VerbindungForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartseiteForm.Show();
        }

        private void vSuchanzeigen_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vSuchanzeigen_dgv.Columns[e.ColumnIndex].Name != "Teilen_colBtn")
            {
                return;
            }

            var row = vSuchanzeigen_dgv.Rows[e.RowIndex];

            string? abfahrt = row.Cells[0].Value?.ToString();
            string? ankunft = row.Cells[1].Value?.ToString();
            string? dauer = row.Cells[2].Value?.ToString();
            string? gleis = row.Cells[3].Value?.ToString();
            string? verspätung = row.Cells[4].Value?.ToString();

            Mailing mailing = new Mailing(abfahrt, ankunft, dauer, gleis, verspätung);

            mailing.OpenMailClientandFillIn();
        }

        private void Autosuggestions(ComboBox comboBoxObjekt)
        {
            if (string.IsNullOrEmpty(comboBoxObjekt.Text) )
            {
                return;
            }
            
            try
            {
                comboBoxObjekt.Items.Clear();
                comboBoxObjekt.SelectionStart = comboBoxObjekt.Text.Length + 1;
                var stations = transport.GetStations(comboBoxObjekt.Text);

                if (stations.StationList.Count == 0)
                {
                    comboBoxObjekt.Items.Clear();
                    comboBoxObjekt.SelectionStart = comboBoxObjekt.Text.Length + 1;
                    comboBoxObjekt.Items.Add("Keine Ergebnisse");
                    return;
                }

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

        private void vSearchAbfahrtsOrt_cbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Autosuggestions(vSearchAbfahrtsOrt_cbx);
            }
        }

        private void vSearchAnkunftsOrt_cbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                Autosuggestions(vSearchAnkunftsOrt_cbx);
            }
        }

        private void vSearchAbfahrtsOrt_cbx_Enter(object sender, EventArgs e)
        {
            vSearchAbfahrtsOrt_cbx.DroppedDown = true;
        }

        private void vSearchAnkunftsOrt_cbx_Enter(object sender, EventArgs e)
        {
            vSearchAnkunftsOrt_cbx.DroppedDown = true;
        }

        private void vSearchAbfahrtsOrt_cbx_Leave(object sender, EventArgs e)
        {
            vSearchAbfahrtsOrt_cbx.DroppedDown = false;
        }

        private void vSearchAnkunftsOrt_cbx_Leave(object sender, EventArgs e)
        {
            vSearchAnkunftsOrt_cbx.DroppedDown = false;
        }
    }
}
