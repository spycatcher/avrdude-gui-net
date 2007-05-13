using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Nastavitve;
namespace avrdudegui.Nastavitve
{
    public partial class nastavitve : Form
    {
        string Mikrokrmilnik_privzeti = null;
        string Programator_privzet = null;
        string standard = null;
        string error = null;

        public nastavitve()
        {
            InitializeComponent();
            odprinastavitve();
            parsenastavitve();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Mikrokrmilnik_privzeti = micsel.Items[micsel.SelectedIndex].ToString();
            Programator_privzet = progsel.Items[progsel.SelectedIndex].ToString();
            shraninastavitve();                  
        }

        void odprinastavitve()
        {
            SettingsFile.Create(Application.LocalUserAppDataPath + @"\nastavitve.xml");
            SettingsKey settings = SettingsFile.Settings["Program"];
            this.Mikrokrmilnik_privzeti = settings.GetSetting("Mikrokontroler", "m8 ATMEGA8");
            this.Programator_privzet = settings.GetSetting("Programator", "usbasp");
        }

        void shraninastavitve()
        {
            SettingsKey settings = SettingsFile.Settings["Program"];
            settings.StoreSetting("Mikrokontroler", this.Mikrokrmilnik_privzeti);
            settings.StoreSetting("Programator", this.Programator_privzet);
            SettingsFile.Update();
        }
        void parsenastavitve()
        {
            micsel.Items.Clear();
            progsel.Items.Clear();
            string[] data = zagon("-c test").Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in data)
            {
                progsel.Items.Add(s.Replace(" ", "").Split('=')[0]);
            }
            progsel.Items.RemoveAt(0);
            progsel.Items.RemoveAt(0);
            progsel.Sorted = true;
            progsel.Refresh();
            progsel.SelectedIndex = progsel.Items.IndexOf(Programator_privzet);
            data = zagon("-c " + Programator_privzet).Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in data)
            {
                micsel.Items.Add(s.Replace(" ", "").Replace("=", " ").Split('[')[0]);
            }
            micsel.Items.RemoveAt(0);
            micsel.Items.RemoveAt(0);
            micsel.Sorted = true;
            micsel.Refresh();
            micsel.SelectedIndex = micsel.Items.IndexOf(Mikrokrmilnik_privzeti);
        }
        public string zagon(string vukaz)
        {
            Process run = new System.Diagnostics.Process();
            try
            {
                run.StartInfo.FileName = "avrdude";
                run.StartInfo.Arguments = vukaz;
                run.StartInfo.UseShellExecute = false;
                run.StartInfo.CreateNoWindow = true;
                run.StartInfo.RedirectStandardError = true;
                run.StartInfo.RedirectStandardOutput = true;
                run.Start();
                error = run.StandardError.ReadToEnd();
                standard = run.StandardOutput.ReadToEnd();
                run.WaitForExit();
                run.Close();
                return error.Replace("avrdude.exe", "").Replace(":", "");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.ToString());
                return e.Message.ToString();
            }
        }

    }

}
