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

namespace SwissTransport.UI
{
    public partial class Details : Form
    {
        //Membervariablen
        private Connection _connection;
        //Konstruktor
        public Details(Connection connection)
        {
            InitializeComponent();
            _connection = connection;
            listView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.None);

            //MapsIcon hinzufügen
            var imagelist = new ImageList();
            imagelist.Images.Add(Image.FromFile(Directory.GetCurrentDirectory() + "\\images\\marker-512.png"));
            imagelist.ImageSize = new Size(20, 20);
            listView.SmallImageList = imagelist;

            //Einträge in ListView
            var item = listView.Items.Add(connection.From.Station.Name);
            item.SubItems.Add("Ab" + DateTime.Parse(connection.From.Departure).ToShortTimeString());
            item.SubItems.Add(connection.From.Platform);
            item.Tag = connection.From.Station;
            item.ImageIndex = 0;

            item = listView.Items.Add(connection.To.Station.Name);
            item.SubItems.Add("An" + DateTime.Parse(connection.To.Arrival).ToShortTimeString());
            item.SubItems.Add(connection.To.Platform);
            item.SubItems.Add(MainView.ConvertDuration(connection.Duration).ToString());
            item.Tag = connection.To.Station;
            item.ImageIndex = 0;
        }

        private void OnlistView_DoubleClick(object sender, EventArgs e)
        {
            //Wenn eine Station gedoppelklickt wird, wird eine Karte geöffnet die die Station zeigt
            var item = listView.SelectedItems[0];
            var station = (Station)item.Tag;

            new Map(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate).ShowDialog();
        }
    }
}
