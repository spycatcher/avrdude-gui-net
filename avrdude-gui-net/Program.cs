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
			parsenastavitve();
			if (Vrednosti.Datoteka_hex != null)
			{
				Obvestila.AppendText("Pot: " + Vrednosti.Datoteka_hex + Environment.NewLine);
			}

		}


		void preberi_pomnilnik_Click(object sender, System.EventArgs e)
		{
			if (shrani.ShowDialog() == DialogResult.OK)
			{
				string[] cip = Vrednosti.Mikrokontroler.Split(' ');
				string vrsta = null;
				string vkljucim_port = " -P " + Vrednosti.Port;
				if (!port_check.Checked) vkljucim_port = null;
				switch (Path.GetExtension(shrani.FileName))
				{
					case ".hex":
						vrsta = ":i";
						break;
					case ".rom":
						vrsta = ":s";
						break;
					case ".bin":
						vrsta = ":r";
						break;
				}
				Obvestila.AppendText(Pripomočki.Zagon(@"-c " + Vrednosti.Programator + " -p " + cip[0] + " -P " + vkljucim_port + " -q -U flash:r:" + Path.GetFileName(shrani.FileName) + vrsta));
			}
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

		private void supportedProgrammersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vrednosti.Programator = progsel.SelectedItem.ToString();
			Obvestila.AppendText("Izbran programator: " + Vrednosti.Programator + Environment.NewLine);
		}

		private void suportedDevicesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Vrednosti.Mikrokontroler = micsel.SelectedItem.ToString();
			string[] cip = Vrednosti.Mikrokontroler.Split(' ');
			Obvestila.AppendText("Izbran mikrokontroler: " + cip[1] + Environment.NewLine);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string cip = Vrednosti.Mikrokontroler.Split(' ')[1].ToLower().Remove(0, 2);
			cip = "AT" + cip;
			string naslov = "http://www.engbedded.com/cgi-bin/fcx.cgi?P_PREV=" + cip + "&P=" + cip + Vrednosti.Spletna_stran + "&O_HEX=Apply+user+values";
			System.Diagnostics.Process.Start(naslov);
		}

		private void zapiši_varovalke_Click(object sender, EventArgs e)
		{
			string[] cip = Vrednosti.Mikrokontroler.Split(' ');
			string vkljucim_port = " -P " + Vrednosti.Port;
			if (!port_check.Checked) vkljucim_port = null;
			DialogResult result;
			result = MessageBox.Show("Ali ste prepričani da želite zapisati varovalke?", "", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Obvestila.AppendText(Pripomočki.Zagon(@"-c " + Vrednosti.Programator + " -p " + cip[0] + vkljucim_port + " -s -q -e -u -U hfuse:w:0x" + hfuse_vrstica.Text + ":m -U lfuse:w:0x" + lfuse_vrstica.Text + ":m"));
			}
		}

		void preberi_varovalke_Click(object sender, System.EventArgs e)
		{
			string[] cip = Vrednosti.Mikrokontroler.Split(' ');
			string vkljucim_port = " -P " + Vrednosti.Port;
			if (!port_check.Checked) vkljucim_port = null;
			Vrednosti.Spletna_stran = null;
			Obvestila.AppendText(Pripomočki.Zagon(@"-c " + Vrednosti.Programator + " -p " + cip[0] + vkljucim_port + " -q -U lock:r:lock:h -U lfuse:r:lfuse:h -U hfuse:r:hfuse:h -U efuse:r:efuse:h"));

			if (File.Exists("lfuse"))
			{
				lfuse_vrstica.Enabled = true;
				lfuse_vrstica.Text = File.OpenText("lfuse").ReadLine().Remove(0, 2).ToUpper();
				Vrednosti.Spletna_stran += "&V_LOW=" + lfuse_vrstica.Text;
			}
			if (File.Exists("hfuse"))
			{
				hfuse_vrstica.Enabled = true;
				hfuse_vrstica.Text = File.OpenText("hfuse").ReadLine().Remove(0, 2).ToUpper();
				Vrednosti.Spletna_stran += "&V_HIGH=" + hfuse_vrstica.Text;
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

		void parsenastavitve()
		{
			try
			{
				micsel.Items.Clear();
				progsel.Items.Clear();
				string[] data = Pripomočki.Zagon("-c test").Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				foreach (string s in data)
				{
					progsel.Items.Add(s.Replace(" ", "").Split('=')[0]);
				}
				progsel.Items.RemoveAt(0);
				progsel.Items.RemoveAt(0);
				progsel.Sorted = true;
				progsel.Refresh();
				progsel.SelectedIndex = progsel.Items.IndexOf(Vrednosti.Programator);
				data = Pripomočki.Zagon("-c " + Vrednosti.Programator).Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				foreach (string s in data)
				{
					micsel.Items.Add(s.Replace(" ", "").Replace("=", " ").Split('[')[0]);
				}
				micsel.Items.RemoveAt(0);
				micsel.Items.RemoveAt(0);
				micsel.Sorted = true;
				micsel.Refresh();
				micsel.SelectedIndex = micsel.Items.IndexOf(Vrednosti.Mikrokontroler);
				Port.Text = Vrednosti.Port;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		private void spremembapoložaja(object sender, TabControlCancelEventArgs e)
		{
			try {
				if (e.TabPage.Name == "Nastavitve")
				{
					Vrednosti.Mikrokontroler = micsel.Items[micsel.SelectedIndex].ToString();
					Vrednosti.Programator = progsel.Items[progsel.SelectedIndex].ToString();
					Vrednosti.Port = Port.Text;
				}
				if (e.TabPage.Name == "Vizitka")
				{
					this.Text = String.Format("About {0}", Pripomočki.AssemblyTitle);
					this.labelProductName.Text = Pripomočki.AssemblyProduct;
					this.labelVersion.Text = String.Format("Version {0}", Pripomočki.AssemblyVersion);
					this.labelCopyright.Text = Pripomočki.AssemblyCopyright;
					this.labelCompanyName.Text = Pripomočki.AssemblyCompany;
					this.textBoxDescription.Text = Pripomočki.AssemblyDescription;
				}
			} catch (Exception f) {
				Console.WriteLine(f.Message);
			}


		}

		private void izberi_datoteko_Click(object sender, EventArgs e)
		{
			if (izbira.ShowDialog() == DialogResult.OK)
			{
				if (izbira.OpenFile() != null)
				{
					Vrednosti.Datoteka_hex = izbira.FileName;
					zap_gumb_flash.Enabled = true;
					Obvestila.AppendText(Vrednosti.Datoteka_hex);
				}
			}
		}

		private void zapiši_POMINLNIK_Click(object sender, EventArgs e)
		{
			string[] cip = Vrednosti.Mikrokontroler.Split(' ');
			string vkljucim_port = " -P " + Vrednosti.Port;
			if (!port_check.Checked) vkljucim_port = null;
			Obvestila.AppendText(Pripomočki.Zagon(@"-c " + Vrednosti.Programator + " -p " + cip[0] + vkljucim_port + " -q -U flash:w:" + Path.GetFileName(Vrednosti.Datoteka_hex) + ":a"));
		}

		private void sprememba_porta(object sender, EventArgs e)
		{
			Port.Enabled = port_check.Checked;
		}

	}
}
