using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport.UI
{
    public partial class Map : Form
    {
        public Map(double x, double y)
        {
            InitializeComponent();
            EmulateWebbrowser();
            webBrowser.Url = new Uri(@"http://maps.google.com/maps?z=12&t=m&q=loc:" + x + "+" + y);
        }

        /// <summary>
        /// Configuriert den Webbrowser, so dass Google Maps läuft
        /// </summary>
        private static void EmulateWebbrowser()
        {
            const string BROWSER_EMULATION_KEY = @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
            string appname = Process.GetCurrentProcess().ProcessName + ".exe";

            const int browserEmulationMode = 9999;

            RegistryKey browserEmulationKey =
            Registry.CurrentUser.OpenSubKey(BROWSER_EMULATION_KEY, RegistryKeyPermissionCheck.ReadWriteSubTree) ??
            Registry.CurrentUser.CreateSubKey(BROWSER_EMULATION_KEY);

            if (browserEmulationKey != null)
            {
                browserEmulationKey.SetValue(appname, browserEmulationMode, RegistryValueKind.DWord);
                browserEmulationKey.Close();
            }
        }
    }
}
