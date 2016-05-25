using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport.UI
{
    public partial class MainView : Form
    {
        private const string DetailsChar = ">";

        public MainView()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            //Allgemein
            spContMain.Panel2Collapsed = true;
            tBVon.Select();
            dGridViewResult.DataSource = CreateEmptyDataTable();
            datePicker.Value = DateTime.Today;
            timePicker.Value = DateTime.Now;

            //AutoComplete
            var allStations = new Transport().GetStations(string.Empty);

            var allowedStations = new AutoCompleteStringCollection();
            allowedStations.AddRange(allStations.StationList.Select(x => x.Name).ToArray());

            ConfigureAutoComplete(tBVon, allowedStations);
            ConfigureAutoComplete(tBNach, allowedStations);
        }

        private void ConfigureAutoComplete(TextBox textbox, AutoCompleteStringCollection value)
        {
            textbox.AutoCompleteCustomSource = value;
            textbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void OnbtnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            string von = tBVon.Text;
            string nach = tBNach.Text;
            DateTime date = datePicker.Value.Date;
            TimeSpan time = timePicker.Value.TimeOfDay;

            dGridViewResult.DataSource = GetSearchResults(von, nach);
            dGridViewResult.AutoResizeColumns();
            dGridViewResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dGridViewResult.Rows.Count == 0)
            {
                spContMain.Panel2Collapsed = true;
                Size = MinimumSize;
            }
            else
            {
                spContMain.Panel2Collapsed = false;
            }

            Cursor.Current = Cursors.Default;
        }

        private DataTable GetSearchResults(string von, string nach)
        {
            DataTable table = CreateEmptyDataTable();
            var transport = new Transport();

            foreach (var connection in transport.GetConnections(von, nach).ConnectionList)
            {
                DateTime departure = DateTime.Parse(connection.From.Departure);
                DateTime arrival = DateTime.Parse(connection.To.Arrival);

                TimeSpan duration = TimeSpan.Parse(connection.Duration.Remove(0, 3));
                int days = int.Parse(connection.Duration.Substring(0, 2));
                duration = duration.Add(new TimeSpan(days, 0, 0, 0));

                table.Rows.Add(
                    departure.ToShortTimeString(),
                    arrival.ToShortTimeString(),
                    duration,
                    DetailsChar);
            }

            return table;
        }

        private DataTable CreateEmptyDataTable()
        {
            DataTable table = new DataTable("Verbindungen");

            table.Columns.Add("Ab");
            table.Columns.Add("An");
            table.Columns.Add("Dauer");
            table.Columns.Add("Details");

            return table;
        }

        private void tB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                OnbtnSearch_Click(null, null);
            }
        }
    }
}
