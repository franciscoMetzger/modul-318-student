using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;

namespace SwissTransport.UI
{
    public partial class MainView : Form
    {
        //Membervariablen
        private const string DetailsChar = ">";
        private readonly List<string> _stations = new List<string>();
        private List<Connection> _currentConnections = new List<Connection>();
        private List<StationBoard> _currentStationBoards = new List<StationBoard>();
        private Transport _transport = new Transport();
        private bool _isArivalTime = false;

        //Konstruktor
        public MainView()
        {
            InitializeComponent();
            Initialize();

            //Alle Stationen aus einem Textfile für die Autocompletion lesen
            string path = Directory.GetCurrentDirectory() + "\\data\\Stations.txt";
            if (File.Exists(path))
            {
                _stations = new List<string>(File.ReadAllLines(path, Encoding.Default));
            }
        }

        //Events
        private void OnbtnSearch_Click(object sender, EventArgs e)
        {
            //Zeit und Datum auslesen
            DateTime date = datePicker.Value.Date;
            TimeSpan time = timePicker.Value.TimeOfDay;

            //FillDataGrid wird mit einer DataTable von Connections aufgerufen
            Cursor.Current = Cursors.WaitCursor;
            FillDataGrid(GetConnections(tBVon.Text, tBNach.Text, date.Add(time)));
            Cursor.Current = Cursors.Default;
        }

        private void OnbtnSearchAbfahrtstafel_Click(object sender, EventArgs e)
        {
            //Zeit und Datum auslesen
            DateTime date = datePickerAbfahrtstafel.Value.Date;
            TimeSpan time = timePickerAbfahrtstafel.Value.TimeOfDay;

            //FillDataGrid wird mit einer DataTable von der Abfahrtstafel
            Cursor.Current = Cursors.WaitCursor;
            FillDataGrid(GetStationBoard(tbVonAbfahrtstafel.Text, date.Add(time)));
            Cursor.Current = Cursors.Default;
        }

        private void OnbtnArivalDeparture_Click(object sender, EventArgs e)
        {
            //Der wert IsArivalTime ist in den Tags der beiden Buttons definiert
            var button = (Button)sender;
            _isArivalTime = bool.Parse(button.Tag.ToString());

            //Jeweils den anderen Button (Ab/An) umfärben damit klar ist, was gerade selektiert ist
            if (_isArivalTime)
            {
                btnAn.BackColor = SystemColors.Control;
                btnAb.BackColor = Color.DarkGray;
            }
            else
            {
                btnAn.BackColor = Color.DarkGray;
                btnAb.BackColor = SystemColors.Control;
            }
        }

        private void OnbtnSwitch_Click(object sender, EventArgs e)
        {
            //Von und Nach tauschen
            string temp = tBVon.Text;
            tBVon.Text = tBNach.Text;
            tBNach.Text = temp;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            //Wenn der Text über 3 Zeichen lang ist soll die Autocompletion starten
            var textbox = (TextBox)sender;
            if (textbox.Text.Length >= 4 && textbox.Focused)
            {
                //Alle Stationen anzeigen die mit dem Eingegebenen Text anfangen
                var stations = _stations.Where(x => x.StartsWith(textbox.Text));

                var allowedStations = new AutoCompleteStringCollection();
                allowedStations.AddRange(stations.ToArray());
                textbox.AutoCompleteCustomSource = allowedStations;
            }
            else
            {
                textbox.AutoCompleteCustomSource.Clear();
            }
        }

        private void OntabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wenn das Tab gewechselt wird soll die jeweilige TextBox selektiert werden
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    tBVon.Select();
                    break;

                case 1:
                    tbVonAbfahrtstafel.Select();
                    break;
            }

            //Beim wechseln sollen auch die Suchergebnisse zurückgesetzt werden
            spContMain.Panel2Collapsed = true;
            dGridViewResult.DataSource = null;
            dGridViewResult.Columns.Clear();
            _currentConnections.Clear();
            _currentStationBoards.Clear();
        }

        private void OndGridViewResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (DataTable)dGridViewResult.DataSource;
            var row = data.Rows[e.RowIndex];

            /*Um die korrekte Verbindung zu suchen wird auf die Abfahrts/Ankunftszeit und die Dauer geprüft.
            Damit die Verbindung gefunden wird müssen die Werte wieder gleich Konvertiert werden wie sie
            in der Tabelle stehen*/
            var connection = _currentConnections.FirstOrDefault(x =>
            DateTime.Parse(x.From.Departure).ToShortTimeString() == (string)row[0] &&
            DateTime.Parse(x.To.Arrival).ToShortTimeString() == (string)row[1] &&
            ConvertDuration(x.Duration).ToString() == (string)row[2]);

            if (connection != null)
            {
                var details = new Details(connection);
                details.ShowDialog();
            }
        }

        private void OntB_KeyDown(object sender, KeyEventArgs e)
        {
            //Wenn die Entertaste gedrückt wird soll gesucht werden
            if (e.KeyData == Keys.Enter && GetKeyState(Keys.Enter) < 0)
            {
                //Je nach dem von welcher TextBox der Event aufgerufen wird, wird der dazugehörige Click-Event ausgeführt
                if ((string)((TextBox)sender).Tag == "Abfahrtstafel")
                {
                    OnbtnSearchAbfahrtstafel_Click(null, null);
                }
                else
                {
                    OnbtnSearch_Click(null, null);
                }
            }
        }

        //GetKeyState wird gebraucht dass bei der Autocomplete Selektion nicht automatisch gesucht wird
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetKeyState(Keys key);

        //Methoden 
        private void Initialize()
        {
            //Textbox Selektieren, lere Tabelle erstellen
            spContMain.Panel2Collapsed = true;
            tBVon.Select();

            //An-Button einfärben
            btnAn.BackColor = Color.DarkGray;

            //Heutiges Datum einstellen
            datePicker.Value = DateTime.Today;
            datePickerAbfahrtstafel.Value = DateTime.Today;
            timePicker.Value = DateTime.Now;
            timePickerAbfahrtstafel.Value = DateTime.Now;
        }

        private void FillDataGrid(DataTable datatable)
        {
            dGridViewResult.DataSource = datatable;
            dGridViewResult.AutoResizeColumns();

            //Bei der Abfahrtstafel gibt es die Detials-Spalte nicht, also soll sie nicht Formatiert werden
            if (dGridViewResult.Columns.Count == 4)
            {
                dGridViewResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //Wenn es Suchergebnisse gibt soll die Tabelle angezeigt werden
            spContMain.Panel2Collapsed = dGridViewResult.Rows.Count == 0;
        }

        private DataTable GetConnections(string von, string nach, DateTime departureTime)
        {
            DataTable table = CreateEmptyDataTable(true);
            _currentConnections = _transport.GetConnections(von, nach, departureTime, _isArivalTime).ConnectionList;

            //Durch alle gefundenen Verbindungen iterieren und neue Rows hinzugefügt
            foreach (var connection in _currentConnections)
            {
                DateTime departure = DateTime.Parse(connection.From.Departure);
                DateTime arrival = DateTime.Parse(connection.To.Arrival);

                table.Rows.Add(
                        departure.ToShortTimeString(),
                        arrival.ToShortTimeString(),
                        ConvertDuration(connection.Duration),
                        DetailsChar);
            }
            return table;
        }

        private DataTable GetStationBoard(string von, DateTime departure)
        {
            DataTable table = CreateEmptyDataTable(false);
            _currentStationBoards = _transport.GetStationBoard(von, departure).Entries;

            //Durch alle Einträge im StationBoard iterieren und in die DataTable abfüllen
            foreach (var board in _currentStationBoards)
            {
                table.Rows.Add(
                    board.Stop.Departure.ToShortTimeString(),
                    board.Name,
                    board.To);
            }
            return table;
        }

        private DataTable CreateEmptyDataTable(bool isConnection)
        {
            DataTable table = new DataTable("Verbindungen");

            //Je nach Fall (Verbindung/Abfahrtstafel) müssen verschiedene Spalten in der DataTable erstellt werden
            if (isConnection)
            {
                table.Columns.Add("Ab");
                table.Columns.Add("An");
                table.Columns.Add("Dauer");
                table.Columns.Add("Details");
            }
            else
            {
                table.Columns.Add("Ab");
                table.Columns.Add("Verbindung");
                table.Columns.Add("Nach");
            }
            return table;
        }

        public static TimeSpan ConvertDuration(string duation)
        {
            //Da die Dauer ein spezielles Format hat muss der String auseinander genommen,
            //einzeln konvertiert und dann wieder zusammen gesetzt werden
            TimeSpan duration = TimeSpan.Parse(duation.Remove(0, 3));
            int days = int.Parse(duation.Substring(0, 2));
            duration = duration.Add(new TimeSpan(days, 0, 0, 0));

            return duration;
        }
    }
}
