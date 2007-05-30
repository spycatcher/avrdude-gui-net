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
    public partial class fuses : Form
    {
        string Mikrokrmilnik_privzeti = null;
        string Port_privzet = null;
        string Programator_privzet = null;
        string standard = null;
        string error = null;
        string spletna_stran_ukazi = null;
        public fuses()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string cip = avrdudegui.GUI.Mikrokrmilnik_privzeti.Split(' ')[1].ToLower().Remove(0, 2); ;
            cip = "AT" + cip;
            string naslov = "http://palmavr.sourceforge.net/cgi-bin/fc.cgi?P_PREV=" + cip + "&P=" + cip + spletna_stran_ukazi + "&O_HEX=Apply+user+values";
            avrdudegui.GUI.textBox3.AppendText(Environment.NewLine + naslov);
            System.Diagnostics.Process.Start(naslov);
        }

        private void zapiši_varovalke_Click(object sender, EventArgs e)
        {
            string[] cip = Mikrokrmilnik_privzeti.Split(' ');
            DialogResult result;
            result = MessageBox.Show("Ali ste preprièani da želite zapisati varovalke?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                zagon(@"-c " + Programator_privzet + " -p " + cip[0] + " -P " + Port_privzet + " -s -q -e -u -U hfuse:w:0x" + hfuse_vrstica.Text + ":m -U lfuse:w:0x" + lfuse_vrstica.Text + ":m");
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

        public string zagon(string vukaz)
        {
            Process run = new System.Diagnostics.Process();
            try
            {

                run.StartInfo.FileName = avrdudegui.GUI.avrdude;
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
                avrdudegui.GUI.textBox3.Clear();
                avrdudegui.GUI.textBox3.AppendText("Ukazni niz: avrdude " + vukaz + Environment.NewLine + Environment.NewLine);
                avrdudegui.GUI.textBox3.AppendText(standard.Replace("avrdude.exe: safemode:", ""));
                avrdudegui.GUI.textBox3.AppendText(error.Replace("avrdude.exe", "").Replace(", or use -F to override this check", "").Replace(":", ""));
                if (error.Contains("AVR device initialized and ready to accept instructions") & error.Contains("error programm enable"))
                {
                    //povezava_gumb.Text = "Poveži";
                    //NASTAVITVE_gumb.Enabled = true;
                    ////lfuse_vrstica.Enabled = false;
                    ////hfuse_vrstica.Enabled = false;
                    ////efuse_vrstica.Enabled = false;
                    ////lockb_vrstica.Enabled = false;
                    //izberi_hex.Enabled = false;
                    ////zapiši_varovalke.Enabled = false;
                    ////preberi_varovalke.Enabled = false;
                    //zapiši_hex.Enabled = false;
                    ////povezava_do_kalkulatorja.Enabled = false;
                }
                return error.Replace("avrdude.exe", "").Replace(":", "");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.Message.ToString();
            }
        }
    }
}