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
        public static string Mikrokrmilnik_privzeti = null;
        public static string Programator_privzet = null;
        public static string Port_privzet = null;
        public static string spletna_stran_ukazi = null;
        public static string avrdude = null;
        public string error = null;
        public string standard = null;
        [STAThread]
        public static void Main(string[] args)
        {
            foreach (string s in args)
            {

                if (s.ToLower().Contains("if="))
                {
                    pot = s.ToLower().Replace("-", "").Replace("if=", ""); ;
                }
                if (s.ToLower().Contains("dpart="))
                {
                    mic = s.ToLower().Replace("-", "").Replace("dpart=", "");
                }

            }
            if (File.Exists(Environment.CurrentDirectory + "//avrdude.exe")) avrdude = Environment.CurrentDirectory + "//avrdude.exe";
            else avrdude = "avrdude";
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
            try
            {
                SettingsFile.Create(@"\nastavitve.xml");
                SettingsKey settings = SettingsFile.Settings["Program"];
                Mikrokrmilnik_privzeti = settings.GetSetting("Mikrokontroler", "m8 ATMEGA8");
                Programator_privzet = settings.GetSetting("Programator", "usbasp");
                Port_privzet = settings.GetSetting("Port", "usb");
            }
            catch (Exception)
            {
                
                throw;
            }
            if (mic.Length > 0)
            {
                povezava_gumb.Enabled = false;
                textBox3.Clear();
                textBox3.AppendText("Mikrokontroler: " + mic + Environment.NewLine);

            }
            if (pot.Length > 0)
            {
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

            string izhod = zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -P " + Port_privzet + " -s -q -e -U flash:w:" + "\"" + pot + "\"" + ":a");
            if (izhod.Contains("AVR device initialized and ready to accept instructions") & izhod.Contains("error programm enable"))
            {
                if (mic.Length > 0)
                {
                    Console.WriteLine(standard);
                }
                else
                {
                    povezava_gumb.Text = "Poveži";
                    NASTAVITVE_gumb.Enabled = true;
                    lfuse_vrstica.Enabled = false;
                    hfuse_vrstica.Enabled = false;
                    efuse_vrstica.Enabled = false;
                    lockb_vrstica.Enabled = false;
                    izberi_hex.Enabled = false;
                    zapiši_varovalke.Enabled = false;
                    preberi_varovalke.Enabled = false;
                    zapiši_hex.Enabled = false;
                }
            }
            else
                if (mic.Length > 0)
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

        public string zagon(string vukaz)
        {
            Process run = new System.Diagnostics.Process();
            try
            {
                run.StartInfo.FileName = avrdude;
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
                textBox3.AppendText("Ukazni niz: avrdude " + vukaz + Environment.NewLine + Environment.NewLine);
                textBox3.AppendText(standard.Replace("avrdude.exe: safemode:", ""));
                textBox3.AppendText(error.Replace("avrdude.exe", "").Replace(", or use -F to override this check", "").Replace(":", ""));
                if (error.Contains("AVR device initialized and ready to accept instructions") & error.Contains("error programm enable"))
                {
                    povezava_gumb.Text = "Poveži";
                    NASTAVITVE_gumb.Enabled = true;
                    lfuse_vrstica.Enabled = false;
                    hfuse_vrstica.Enabled = false;
                    efuse_vrstica.Enabled = false;
                    lockb_vrstica.Enabled = false;
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
                Console.WriteLine(e.ToString());
                return e.Message.ToString();
            }
        }


        void povezava_gumb_Click(object sender, System.EventArgs e)
        {
            if (!povezava_gumb.Text.Contains("Prekini"))
            {
                string[] cip = Mikrokrmilnik_privzeti.Split(' ');
                string izhod = zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -P " + Port_privzet + " -s -q");
                if (izhod.Contains("AVR device initialized and ready to accept instructions") & !izhod.Contains("Double check chip") & !izhod.Contains("Yikes!"))
                {
                    //lfuse_vrstica.Enabled = true;
                    //hfuse_vrstica.Enabled = true;
                    //efuse_vrstica.Enabled = true;
                    //lockb_vrstica.Enabled = true;
                    izberi_hex.Enabled = true;
                    //zapiši_varovalke.Enabled = true;
                    preberi_varovalke.Enabled = true;
                    //povezava_do_kalkulatorja.Enabled = true;
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
                efuse_vrstica.Enabled = false;
                lockb_vrstica.Enabled = false;
                lfuse_vrstica.Clear();
                hfuse_vrstica.Clear();
                efuse_vrstica.Clear();
                lockb_vrstica.Clear();
                izberi_hex.Enabled = false;
                zapiši_varovalke.Enabled = false;
                preberi_varovalke.Enabled = false;
                zapiši_hex.Enabled = false;
                povezava_do_kalkulatorja.Enabled = false;
            }

        }

        void preberi_varovalke_Click(object sender, System.EventArgs e)
        {
            string[] cip = Mikrokrmilnik_privzeti.Split(' ');
            spletna_stran_ukazi = null;
            string izhod = zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -P " + Port_privzet + " -q -U lock:r:lock:h -U lfuse:r:lfuse:h -U hfuse:r:hfuse:h -U efuse:r:efuse:h");

            if (File.Exists("lfuse"))
            {
                lfuse_vrstica.Enabled = true;
                lfuse_vrstica.Text = File.OpenText("lfuse").ReadLine().Remove(0, 2).ToUpper();
                spletna_stran_ukazi += "&V_LOW=" + lfuse_vrstica.Text;
            }
            if (File.Exists("hfuse"))
            {
                hfuse_vrstica.Enabled = true;
                hfuse_vrstica.Text = File.OpenText("hfuse").ReadLine().Remove(0, 2).ToUpper();
                spletna_stran_ukazi += "&V_HIGH=" + hfuse_vrstica.Text;
            }
            if (File.Exists("lock"))
            {
                lockb_vrstica.Enabled = true;
                lockb_vrstica.Text = File.OpenText("lock").ReadLine().Remove(0, 2).ToUpper();
            }
            if (File.Exists("efuse"))
            {
                efuse_vrstica.Enabled = true;
                efuse_vrstica.Text = File.OpenText("lock").ReadLine().Remove(0, 2).ToUpper();
            }
            zapiši_varovalke.Enabled = true;
            povezava_do_kalkulatorja.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string cip = Mikrokrmilnik_privzeti.Split(' ')[1].ToLower().Remove(0, 2); ;
            cip = "AT" + cip;
            string naslov = "http://palmavr.sourceforge.net/cgi-bin/fc.cgi?P_PREV=" + cip + "&P=" + cip + spletna_stran_ukazi + "&O_HEX=Apply+user+values";
            textBox3.AppendText(Environment.NewLine + naslov);
            System.Diagnostics.Process.Start(naslov);
        }

        private void zapiši_varovalke_Click(object sender, EventArgs e)
        {
            string[] cip = Mikrokrmilnik_privzeti.Split(' ');
            DialogResult result;
            result = MessageBox.Show("Ali ste prepričani da želite zapisati varovalke?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -P " + Port_privzet + " -s -q -e -u -U hfuse:w:0x" + hfuse_vrstica.Text + ":m -U lfuse:w:0x" + lfuse_vrstica.Text + ":m");
            }
        }

        private void NASTAVITVE_gumb_Click(object sender, EventArgs e)
        {
            nastavitve sp = new nastavitve();
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


    }
}
