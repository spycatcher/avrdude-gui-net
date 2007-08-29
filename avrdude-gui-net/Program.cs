/*
 * Created by SharpDevelop.
 * User: Janez
 * Date: 28.1.2007
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using avrdudegui.Orodja;
namespace avrdudegui
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class Program : Form
    {
        public string error = null;
        public string standard = null;
        [STAThread]
        public static void Main(string[] args)
        {
            Vrednosti.Odpri();
            foreach (string s in args)
            {
                if (s.ToLower().Contains("if="))
                {
                    Vrednosti.Datoteka_hex = s.ToLower().Replace("-", "").Replace("if=", "");
                }

            }
            if (File.Exists(Environment.CurrentDirectory + "//avrdude.exe")) Vrednosti.Avrdude_pot = Environment.CurrentDirectory + "//avrdude.exe";
            else Vrednosti.Avrdude_pot = "avrdude";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        public Program()
        {
            InitializeComponent();
            if (Vrednosti.Datoteka_hex != null)
            {
                Obvestila.AppendText("Pot: " + Vrednosti.Datoteka_hex + Environment.NewLine);
            }
        }


        void izberi_hex_Click(object sender, System.EventArgs e)
        {
            if (izbira.ShowDialog() == DialogResult.OK)
            {
                if (izbira.OpenFile() != null)
                {
                    Vrednosti.Datoteka_hex = izbira.FileName;
                }
            }
        }


        void zapiši_hex_Click(object sender, System.EventArgs e)
        {
            string[] cip = Vrednosti.Mikrokontroler.Split(' ');

            string izhod = Pripomočki.Zagon(@"-c " + Vrednosti.Programator + " -p " + cip[0] + " -P " + Vrednosti.Port + " -s -q -e -U flash:w:" + "\"" + Vrednosti.Datoteka_hex + "\"" + ":a");
            if (izhod.Contains("AVR device initialized and ready to accept instructions") & izhod.Contains("error programm enable"))
            {
                if (Vrednosti.Mikrokontroler.Length > 0)
                {
                    Console.WriteLine(standard);
                }
            }
            else
                if (Vrednosti.Mikrokontroler.Length > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("Ali zaprem Avrdude GUI aplikacijo?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Console.WriteLine(izhod);
                        Application.Exit();
                    }

                }

        }

        void povezava_gumb_Click(object sender, System.EventArgs e)
        {
            string[] cip = Vrednosti.Mikrokontroler.Split(' ');
            string izhod = Pripomočki.Zagon(@"-c " + Vrednosti.Programator + " -p " + cip[0] + " -P " + Vrednosti.Port + " -s -q");
        }

        private void NASTAVITVE_gumb_Click(object sender, EventArgs e)
        {
            Nastavitve sp = new Nastavitve();
            sp.ShowDialog();
        }

        private void VIZITKA_gumb_Click(object sender, EventArgs e)
        {
            Vizitka sp = new Vizitka();
            sp.ShowDialog();
        }

        private void ob_zagonu(object sender, EventArgs e)
        {
            if (File.Exists("lfuse"))
                File.Delete("lfuse");

            if (File.Exists("hfuse"))
                File.Delete("hfuse");

            if (File.Exists("lock"))
                File.Delete("lock");

            if (File.Exists("efuse"))
                File.Delete("efuse");
        }

        private void Izhod_klik(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Varovalke sp = new Varovalke();
            sp.ShowDialog();
        }

        private void supportedProgrammersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obvestila.Clear();
            Obvestila.AppendText(Pripomočki.Zagon(@"-c test"));
        }

        private void suportedDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obvestila.Clear();
            Obvestila.AppendText(Pripomočki.Zagon(@"-c "+Vrednosti.Programator+" -p AVRDUDEGUI"));
        }


    }
}
