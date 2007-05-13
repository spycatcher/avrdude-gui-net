/*
 * Created by SharpDevelop.
 * User: Janez
 * Date: 28.1.2007
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using avrdudegui.Nastavitve;
using Nastavitve;
namespace avrdudegui
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm
    {
        public static string pot = "";
        public static string mic = "";
        public static string Mikrokrmilnik_privzeti = "";
        public static string Programator_privzet = "";
        public static string avrdude = Environment.CurrentDirectory;
        public string error = null;
        public string standard = null;
        [STAThread]
        public static void Main(string[] args)
        {
            foreach (string s in args)
            {

                if (s.Contains("if="))
                {
                    pot = s;
                }
                if (s.Contains("dpart="))
                {
                    mic = s;
                }

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            SettingsFile.Create(Application.LocalUserAppDataPath + @"\nastavitve.xml");
            SettingsKey settings = SettingsFile.Settings["Program"];
            Mikrokrmilnik_privzeti = settings.GetSetting("Mikrokontroler", "m8 ATMEGA8");
            Programator_privzet = settings.GetSetting("Programator", "usbasp");
            if (mic.Length > 0)
            {
                povezava_gumb.Enabled = false;
                mic = mic.Remove(0, 7);
                textBox3.Clear();
                textBox3.AppendText("Mikrokontroler: " + mic + Environment.NewLine);

            }
            if (pot.Length > 0)
            {
                pot = pot.Remove(0, 3);
                zapiši_hex.Enabled = true;
                textBox3.AppendText("Pot: " + pot + Environment.NewLine);
            }
            else
                zapiši_hex.Enabled = false;


        }


        void izberi_hex_Click(object sender, System.EventArgs e)
        {

            if (izbira.ShowDialog() == DialogResult.OK)
            {
                if (izbira.OpenFile() != null)
                {
                    pot = izbira.FileName;
                    zapiši_hex.Enabled = true;

                }
            }


        }


        void zapiši_hex_Click(object sender, System.EventArgs e)
        {
            string[] cip = Mikrokrmilnik_privzeti.Split(' ');

            string izhod = zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -s -q -e -U flash:w:" + "\"" + pot + "\"" + ":a");
            if (izhod.Contains("AVR device initialized and ready to accept instructions") & izhod.Contains("error programm enable"))
            {
                if (mic.Length > 0)
                {
                    Console.WriteLine(izhod);
                    Application.Exit();
                }
                else
                {
                    povezava_gumb.Text = "Poveži";
                    NASTAVITVE_gumb.Enabled = true;
                    lfuse_vrstica.Enabled = false;
                    hfuse_vrstica.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    izberi_hex.Enabled = false;
                    zapiši_varovalke.Enabled = false;
                    preberi_varovalke.Enabled = false;
                    zapiši_hex.Enabled = false;
                }
            }
            else
                if (mic.Length > 0)
                {
                    Console.WriteLine(izhod);
                    Application.Exit();
                }

        }

        public string zagon(string vukaz)
        {
            Process run = new System.Diagnostics.Process();
            try
            {
                run.StartInfo.FileName = avrdude + "\\avrdude.exe";
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
                textBox3.Clear();
                textBox3.AppendText("Ukazni niz: avrdude "+ vukaz + Environment.NewLine + Environment.NewLine);
                textBox3.AppendText(standard.Replace("avrdude.exe: safemode:", ""));
                textBox3.AppendText(error.Replace("avrdude.exe", "").Replace(", or use -F to override this check", "").Replace(":", ""));
                if (error.Contains("AVR device initialized and ready to accept instructions") & error.Contains("error programm enable"))
                {
                    povezava_gumb.Text = "Poveži";
                    NASTAVITVE_gumb.Enabled = true;
                    lfuse_vrstica.Enabled = false;
                    hfuse_vrstica.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    izberi_hex.Enabled = false;
                    zapiši_varovalke.Enabled = false;
                    preberi_varovalke.Enabled = false;
                    zapiši_hex.Enabled = false;
                    povezava_do_kalkulatorja.Enabled = false;
                }
                return error.Replace("avrdude.exe", "").Replace(":", "");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.ToString());
                return e.Message.ToString();
            }
        }


        void povezava_gumb_Click(object sender, System.EventArgs e)
        {
            if (!povezava_gumb.Text.Contains("Prekini"))
            {
                string[] cip = Mikrokrmilnik_privzeti.Split(' ');
                string izhod = zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -s -q");
                if (izhod.Contains("AVR device initialized and ready to accept instructions") & !izhod.Contains("Double check chip") & !izhod.Contains("Yikes!"))
                {
                    lfuse_vrstica.Enabled = true;
                    hfuse_vrstica.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    izberi_hex.Enabled = true;
                    zapiši_varovalke.Enabled = true;
                    preberi_varovalke.Enabled = true;
                    povezava_do_kalkulatorja.Enabled = true;
                    NASTAVITVE_gumb.Enabled = false;
                    povezava_gumb.Text = "Prekini";
                }
            }
            else
            {
                povezava_gumb.Text = "Poveži";
                NASTAVITVE_gumb.Enabled = true;
                lfuse_vrstica.Enabled = false;
                hfuse_vrstica.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                izberi_hex.Enabled = false;
                zapiši_varovalke.Enabled = false;
                preberi_varovalke.Enabled = false;
                zapiši_hex.Enabled = false;
                povezava_do_kalkulatorja.Enabled = false;
            }

        }

        void preveri(object sender, System.EventArgs e)
        {
            povezava_gumb.Enabled = true;
        }

        void preberi_varovalke_Click(object sender, System.EventArgs e)
        {
            string[] cip = Mikrokrmilnik_privzeti.Split(' ');

            string izhod = zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -v -q");
            string[] varovalke = standard.Replace("avrdude.exe: safemode:", "").Split('\n');
            for (int i = 1; i < varovalke.Length - 1 / 2; i++)
            {
                if (varovalke[i].Contains("lfuse"))
                    lfuse_vrstica.Text = varovalke[i].Replace(" lfuse reads as ", "").Remove(2, 1);
                if (varovalke[i].Contains("hfuse"))
                    hfuse_vrstica.Text = varovalke[i].Replace(" hfuse reads as ", "").Remove(2, 1);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] cip = Mikrokrmilnik_privzeti.Split(' ');
            string naslov = "http://palmavr.sourceforge.net/cgi-bin/fc.cgi?P_PREV=" + cip[1] + "&P=" + cip[1] + "&V_LOW=" + lfuse_vrstica.Text + "&V_HIGH=" + hfuse_vrstica.Text + "&O_HEX=Apply+user+values";
            textBox3.AppendText(Environment.NewLine + naslov);
            System.Diagnostics.Process.Start(naslov);
        }

        private void zapiši_varovalke_Click(object sender, EventArgs e)
        {
            string[] cip = Mikrokrmilnik_privzeti.Split(' ');
            string izhod = zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -s -q -e -u -U hfuse:w:0x" + hfuse_vrstica.Text + ":m -U lfuse:w:0x" + lfuse_vrstica.Text + ":m");
        }

        private void NASTAVITVE_gumb_Click(object sender, EventArgs e)
        {
            nastavitve sp = new nastavitve();
            sp.ShowDialog();
        }

        private void VIZITKA_gumb_Click(object sender, EventArgs e)
        {
            vizitka sp = new vizitka();
            sp.ShowDialog();
        }
    }
}
