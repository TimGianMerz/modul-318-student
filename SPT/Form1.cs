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
using System.Net;

namespace SPT
{
    public partial class SPT : Form
    {
        Transport mTransport = new Transport();
        public SPT()
        {
            InitializeComponent();
        }

        /*
         *Diese Methode sorgt für das Autocomplete beim Ausfüllen der Textboxen 
         */
        private void dropDownAutoComplete(ComboBox cbStation)
        {
            try
            {
                string suchtext = cbStation.Text;
                if (suchtext.Length <= 2)
                    return;
                cbStation.Items.Clear();

                var stationenListe = mTransport.GetStations(suchtext).StationList;
                foreach (var einzelneStationen in stationenListe)
                    cbStation.Items.Add(einzelneStationen.Name);
            }
            catch (WebException fehlerObjekt)
            {
                MessageBox.Show("Fehler");
            }

        }

        /// <summary>
        /// Füllt bei einer Verbindungssuche von zwei Stationen die Data Grid View
        /// </summary>
        private void fillDataGridView()
        {
            dgvVerbindungen.Rows.Clear();
            dgvVerbindungen.Refresh();
            String zeit = conDtpDateTime.Text.Remove(0, 9);
            String datum = conDtpDateTime.Text.Remove(9, 5);
                Connections lst = mTransport.GetConnections(conCbVon.Text, conCbBis.Text, datum, zeit);
                foreach (Connection cn in lst.ConnectionList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvVerbindungen);
                    row.Cells[0].Value = cn.From.Station.Name;
                    row.Cells[1].Value = cn.To.Station.Name;
                    row.Cells[2].Value = Convert.ToDateTime(cn.From.Departure).ToString("HH:mm");
                    row.Cells[3].Value = Convert.ToDateTime(cn.To.Arrival).ToString("HH:mm");
                    row.Cells[4].Value = calcTimeDifference(Convert.ToDateTime(cn.From.Departure), Convert.ToDateTime(cn.To.Arrival));
                    dgvVerbindungen.Rows.Add(row);
                }
        }
        
        /*
         * Diese Methode rechnet die zu reisende Zeit bei einer Verbindung aus
         */
        private String calcTimeDifference(DateTime endTime, DateTime startTime)
        {
            TimeSpan span = startTime.Subtract(endTime);
            return span.ToString();
        }
        
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void conCbVon_DropDown(object sender, EventArgs e)
        {
            dropDownAutoComplete(conCbVon);
        }

        private void conCbBis_DropDown(object sender, EventArgs e)
        {
            dropDownAutoComplete(conCbBis);
        }

        private void tafCbVon_DropDown(object sender, EventArgs e)
        {
            dropDownAutoComplete(tafCbVon);
        }

        /*
         * Diese Methode sorg für die Verbindungstafel
         */
        private void tafBtnSuchen_Click(object sender, EventArgs e)
        {
            dgvVerbindungen.Rows.Clear();
            dgvVerbindungen.Refresh();
            var station = mTransport.GetStations(tafCbVon.Text);
            var stationId = station.StationList[0].Id;

            var stationBoard = mTransport.GetStationBoard(tafCbVon.Text, stationId).Entries;

            foreach (var stationB in stationBoard)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvVerbindungen);
                row.Cells[0].Value = tafCbVon.Text;
                row.Cells[1].Value = stationB.To;
                row.Cells[3].Value = stationB.Stop.Departure.ToString();

                dgvVerbindungen.Rows.Add(row);
            }
        }

        private void conCbVon_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = conBtnSuchen;
        }

        private void tafCbVon_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = tafBtnSuchen;
        }
    }
}
