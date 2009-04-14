/*
 * Created by SharpDevelop.
 * User: Janez
 * Date: 28.1.2007
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace avrdudegui
{
	partial class Program : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
			this.izbira = new System.Windows.Forms.OpenFileDialog();
			this.Obvestila = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Glavno = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.FLASH = new System.Windows.Forms.Button();
			this.FLASH_P = new System.Windows.Forms.Button();
			this.zap_gumb_flash = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.EPROM = new System.Windows.Forms.Button();
			this.EPROM_P = new System.Windows.Forms.Button();
			this.zap_gumb_eprom = new System.Windows.Forms.Button();
			this.Varovalke = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.povezava_do_kalkulatorja = new System.Windows.Forms.LinkLabel();
			this.lfuse_vrstica = new System.Windows.Forms.TextBox();
			this.preberi_varovalke = new System.Windows.Forms.Button();
			this.lockb_vrstica = new System.Windows.Forms.TextBox();
			this.efuse_vrstica = new System.Windows.Forms.TextBox();
			this.zapiši_varovalke = new System.Windows.Forms.Button();
			this.hfuse_vrstica = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Nastavitve = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.port_check = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Port = new System.Windows.Forms.TextBox();
			this.progsel = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.micsel = new System.Windows.Forms.ComboBox();
			this.Vizitka = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.shrani = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1.SuspendLayout();
			this.Glavno.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.Varovalke.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.Nastavitve.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.Vizitka.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// izbira
			// 
			resources.ApplyResources(this.izbira, "izbira");
			// 
			// Obvestila
			// 
			resources.ApplyResources(this.Obvestila, "Obvestila");
			this.Obvestila.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.Obvestila.BackgroundImage = null;
			this.Obvestila.Font = null;
			this.Obvestila.Name = "Obvestila";
			this.Obvestila.ReadOnly = true;
			// 
			// tabControl1
			// 
			this.tabControl1.AccessibleDescription = null;
			this.tabControl1.AccessibleName = null;
			resources.ApplyResources(this.tabControl1, "tabControl1");
			this.tabControl1.BackgroundImage = null;
			this.tabControl1.Controls.Add(this.Glavno);
			this.tabControl1.Controls.Add(this.Varovalke);
			this.tabControl1.Controls.Add(this.Nastavitve);
			this.tabControl1.Controls.Add(this.Vizitka);
			this.tabControl1.Font = null;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.spremembapoložaja);
			// 
			// Glavno
			// 
			this.Glavno.AccessibleDescription = null;
			this.Glavno.AccessibleName = null;
			resources.ApplyResources(this.Glavno, "Glavno");
			this.Glavno.BackgroundImage = null;
			this.Glavno.Controls.Add(this.tableLayoutPanel3);
			this.Glavno.Font = null;
			this.Glavno.Name = "Glavno";
			this.Glavno.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AccessibleDescription = null;
			this.tableLayoutPanel3.AccessibleName = null;
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.BackgroundImage = null;
			this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 1);
			this.tableLayoutPanel3.Font = null;
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// groupBox4
			// 
			this.groupBox4.AccessibleDescription = null;
			this.groupBox4.AccessibleName = null;
			resources.ApplyResources(this.groupBox4, "groupBox4");
			this.groupBox4.BackgroundImage = null;
			this.groupBox4.Controls.Add(this.FLASH);
			this.groupBox4.Controls.Add(this.FLASH_P);
			this.groupBox4.Controls.Add(this.zap_gumb_flash);
			this.groupBox4.Font = null;
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.TabStop = false;
			// 
			// FLASH
			// 
			this.FLASH.AccessibleDescription = null;
			this.FLASH.AccessibleName = null;
			resources.ApplyResources(this.FLASH, "FLASH");
			this.FLASH.BackgroundImage = null;
			this.FLASH.Font = null;
			this.FLASH.Name = "FLASH";
			this.FLASH.UseVisualStyleBackColor = true;
			this.FLASH.Click += new System.EventHandler(this.izberi_datoteko_Click);
			// 
			// FLASH_P
			// 
			this.FLASH_P.AccessibleDescription = null;
			this.FLASH_P.AccessibleName = null;
			resources.ApplyResources(this.FLASH_P, "FLASH_P");
			this.FLASH_P.BackgroundImage = null;
			this.FLASH_P.Font = null;
			this.FLASH_P.Name = "FLASH_P";
			this.FLASH_P.UseVisualStyleBackColor = true;
			this.FLASH_P.Click += new System.EventHandler(this.preberi_pomnilnik_Click);
			// 
			// zap_gumb_flash
			// 
			this.zap_gumb_flash.AccessibleDescription = null;
			this.zap_gumb_flash.AccessibleName = null;
			resources.ApplyResources(this.zap_gumb_flash, "zap_gumb_flash");
			this.zap_gumb_flash.BackgroundImage = null;
			this.zap_gumb_flash.Font = null;
			this.zap_gumb_flash.Name = "zap_gumb_flash";
			this.zap_gumb_flash.UseVisualStyleBackColor = true;
			this.zap_gumb_flash.Click += new System.EventHandler(this.zapiši_POMINLNIK_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.AccessibleDescription = null;
			this.groupBox5.AccessibleName = null;
			resources.ApplyResources(this.groupBox5, "groupBox5");
			this.groupBox5.BackgroundImage = null;
			this.groupBox5.Controls.Add(this.EPROM);
			this.groupBox5.Controls.Add(this.EPROM_P);
			this.groupBox5.Controls.Add(this.zap_gumb_eprom);
			this.groupBox5.Font = null;
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.TabStop = false;
			// 
			// EPROM
			// 
			this.EPROM.AccessibleDescription = null;
			this.EPROM.AccessibleName = null;
			resources.ApplyResources(this.EPROM, "EPROM");
			this.EPROM.BackgroundImage = null;
			this.EPROM.Font = null;
			this.EPROM.Name = "EPROM";
			this.EPROM.UseVisualStyleBackColor = true;
			this.EPROM.Click += new System.EventHandler(this.izberi_datoteko_Click);
			// 
			// EPROM_P
			// 
			this.EPROM_P.AccessibleDescription = null;
			this.EPROM_P.AccessibleName = null;
			resources.ApplyResources(this.EPROM_P, "EPROM_P");
			this.EPROM_P.BackgroundImage = null;
			this.EPROM_P.Font = null;
			this.EPROM_P.Name = "EPROM_P";
			this.EPROM_P.UseVisualStyleBackColor = true;
			this.EPROM_P.Click += new System.EventHandler(this.preberi_pomnilnik_Click);
			// 
			// zap_gumb_eprom
			// 
			this.zap_gumb_eprom.AccessibleDescription = null;
			this.zap_gumb_eprom.AccessibleName = null;
			resources.ApplyResources(this.zap_gumb_eprom, "zap_gumb_eprom");
			this.zap_gumb_eprom.BackgroundImage = null;
			this.zap_gumb_eprom.Font = null;
			this.zap_gumb_eprom.Name = "zap_gumb_eprom";
			this.zap_gumb_eprom.UseVisualStyleBackColor = true;
			this.zap_gumb_eprom.Click += new System.EventHandler(this.zapiši_POMINLNIK_Click);
			// 
			// Varovalke
			// 
			this.Varovalke.AccessibleDescription = null;
			this.Varovalke.AccessibleName = null;
			resources.ApplyResources(this.Varovalke, "Varovalke");
			this.Varovalke.BackgroundImage = null;
			this.Varovalke.Controls.Add(this.groupBox1);
			this.Varovalke.Font = null;
			this.Varovalke.Name = "Varovalke";
			this.Varovalke.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = null;
			this.groupBox1.AccessibleName = null;
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.BackgroundImage = null;
			this.groupBox1.Controls.Add(this.povezava_do_kalkulatorja);
			this.groupBox1.Controls.Add(this.lfuse_vrstica);
			this.groupBox1.Controls.Add(this.preberi_varovalke);
			this.groupBox1.Controls.Add(this.lockb_vrstica);
			this.groupBox1.Controls.Add(this.efuse_vrstica);
			this.groupBox1.Controls.Add(this.zapiši_varovalke);
			this.groupBox1.Controls.Add(this.hfuse_vrstica);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = null;
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// povezava_do_kalkulatorja
			// 
			this.povezava_do_kalkulatorja.AccessibleDescription = null;
			this.povezava_do_kalkulatorja.AccessibleName = null;
			resources.ApplyResources(this.povezava_do_kalkulatorja, "povezava_do_kalkulatorja");
			this.povezava_do_kalkulatorja.Font = null;
			this.povezava_do_kalkulatorja.Name = "povezava_do_kalkulatorja";
			this.povezava_do_kalkulatorja.TabStop = true;
			this.povezava_do_kalkulatorja.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// lfuse_vrstica
			// 
			this.lfuse_vrstica.AccessibleDescription = null;
			this.lfuse_vrstica.AccessibleName = null;
			resources.ApplyResources(this.lfuse_vrstica, "lfuse_vrstica");
			this.lfuse_vrstica.BackgroundImage = null;
			this.lfuse_vrstica.Font = null;
			this.lfuse_vrstica.Name = "lfuse_vrstica";
			// 
			// preberi_varovalke
			// 
			this.preberi_varovalke.AccessibleDescription = null;
			this.preberi_varovalke.AccessibleName = null;
			resources.ApplyResources(this.preberi_varovalke, "preberi_varovalke");
			this.preberi_varovalke.BackgroundImage = null;
			this.preberi_varovalke.Font = null;
			this.preberi_varovalke.Name = "preberi_varovalke";
			this.preberi_varovalke.UseVisualStyleBackColor = true;
			this.preberi_varovalke.Click += new System.EventHandler(this.preberi_varovalke_Click);
			// 
			// lockb_vrstica
			// 
			this.lockb_vrstica.AccessibleDescription = null;
			this.lockb_vrstica.AccessibleName = null;
			resources.ApplyResources(this.lockb_vrstica, "lockb_vrstica");
			this.lockb_vrstica.BackgroundImage = null;
			this.lockb_vrstica.Font = null;
			this.lockb_vrstica.Name = "lockb_vrstica";
			// 
			// efuse_vrstica
			// 
			this.efuse_vrstica.AccessibleDescription = null;
			this.efuse_vrstica.AccessibleName = null;
			resources.ApplyResources(this.efuse_vrstica, "efuse_vrstica");
			this.efuse_vrstica.BackgroundImage = null;
			this.efuse_vrstica.Font = null;
			this.efuse_vrstica.Name = "efuse_vrstica";
			// 
			// zapiši_varovalke
			// 
			this.zapiši_varovalke.AccessibleDescription = null;
			this.zapiši_varovalke.AccessibleName = null;
			resources.ApplyResources(this.zapiši_varovalke, "zapiši_varovalke");
			this.zapiši_varovalke.BackgroundImage = null;
			this.zapiši_varovalke.Font = null;
			this.zapiši_varovalke.Name = "zapiši_varovalke";
			this.zapiši_varovalke.UseVisualStyleBackColor = true;
			this.zapiši_varovalke.Click += new System.EventHandler(this.zapiši_varovalke_Click);
			// 
			// hfuse_vrstica
			// 
			this.hfuse_vrstica.AccessibleDescription = null;
			this.hfuse_vrstica.AccessibleName = null;
			resources.ApplyResources(this.hfuse_vrstica, "hfuse_vrstica");
			this.hfuse_vrstica.BackgroundImage = null;
			this.hfuse_vrstica.Font = null;
			this.hfuse_vrstica.Name = "hfuse_vrstica";
			// 
			// label4
			// 
			this.label4.AccessibleDescription = null;
			this.label4.AccessibleName = null;
			resources.ApplyResources(this.label4, "label4");
			this.label4.Font = null;
			this.label4.Name = "label4";
			// 
			// label3
			// 
			this.label3.AccessibleDescription = null;
			this.label3.AccessibleName = null;
			resources.ApplyResources(this.label3, "label3");
			this.label3.Font = null;
			this.label3.Name = "label3";
			// 
			// label2
			// 
			this.label2.AccessibleDescription = null;
			this.label2.AccessibleName = null;
			resources.ApplyResources(this.label2, "label2");
			this.label2.Font = null;
			this.label2.Name = "label2";
			// 
			// label1
			// 
			this.label1.AccessibleDescription = null;
			this.label1.AccessibleName = null;
			resources.ApplyResources(this.label1, "label1");
			this.label1.Font = null;
			this.label1.Name = "label1";
			// 
			// Nastavitve
			// 
			this.Nastavitve.AccessibleDescription = null;
			this.Nastavitve.AccessibleName = null;
			resources.ApplyResources(this.Nastavitve, "Nastavitve");
			this.Nastavitve.BackgroundImage = null;
			this.Nastavitve.Controls.Add(this.tableLayoutPanel2);
			this.Nastavitve.Font = null;
			this.Nastavitve.Name = "Nastavitve";
			this.Nastavitve.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AccessibleDescription = null;
			this.tableLayoutPanel2.AccessibleName = null;
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.BackgroundImage = null;
			this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
			this.tableLayoutPanel2.Font = null;
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// groupBox3
			// 
			this.groupBox3.AccessibleDescription = null;
			this.groupBox3.AccessibleName = null;
			resources.ApplyResources(this.groupBox3, "groupBox3");
			this.groupBox3.BackgroundImage = null;
			this.groupBox3.Controls.Add(this.port_check);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.Port);
			this.groupBox3.Controls.Add(this.progsel);
			this.groupBox3.Font = null;
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.TabStop = false;
			// 
			// port_check
			// 
			this.port_check.AccessibleDescription = null;
			this.port_check.AccessibleName = null;
			resources.ApplyResources(this.port_check, "port_check");
			this.port_check.BackgroundImage = null;
			this.port_check.Checked = true;
			this.port_check.CheckState = System.Windows.Forms.CheckState.Checked;
			this.port_check.Font = null;
			this.port_check.Name = "port_check";
			this.port_check.UseVisualStyleBackColor = true;
			this.port_check.CheckedChanged += new System.EventHandler(this.sprememba_porta);
			// 
			// label5
			// 
			this.label5.AccessibleDescription = null;
			this.label5.AccessibleName = null;
			resources.ApplyResources(this.label5, "label5");
			this.label5.Font = null;
			this.label5.Name = "label5";
			// 
			// Port
			// 
			this.Port.AccessibleDescription = null;
			this.Port.AccessibleName = null;
			resources.ApplyResources(this.Port, "Port");
			this.Port.BackgroundImage = null;
			this.Port.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.Port.Font = null;
			this.Port.Name = "Port";
			// 
			// progsel
			// 
			this.progsel.AccessibleDescription = null;
			this.progsel.AccessibleName = null;
			resources.ApplyResources(this.progsel, "progsel");
			this.progsel.BackgroundImage = null;
			this.progsel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.progsel.Font = null;
			this.progsel.FormattingEnabled = true;
			this.progsel.Items.AddRange(new object[] {
									resources.GetString("progsel.Items"),
									resources.GetString("progsel.Items1")});
			this.progsel.Name = "progsel";
			this.progsel.SelectedIndexChanged += new System.EventHandler(this.supportedProgrammersToolStripMenuItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleDescription = null;
			this.groupBox2.AccessibleName = null;
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.BackgroundImage = null;
			this.groupBox2.Controls.Add(this.micsel);
			this.groupBox2.Font = null;
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// micsel
			// 
			this.micsel.AccessibleDescription = null;
			this.micsel.AccessibleName = null;
			resources.ApplyResources(this.micsel, "micsel");
			this.micsel.BackgroundImage = null;
			this.micsel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.micsel.Font = null;
			this.micsel.FormattingEnabled = true;
			this.micsel.Items.AddRange(new object[] {
									resources.GetString("micsel.Items"),
									resources.GetString("micsel.Items1"),
									resources.GetString("micsel.Items2")});
			this.micsel.Name = "micsel";
			this.micsel.SelectedIndexChanged += new System.EventHandler(this.suportedDevicesToolStripMenuItem_Click);
			// 
			// Vizitka
			// 
			this.Vizitka.AccessibleDescription = null;
			this.Vizitka.AccessibleName = null;
			resources.ApplyResources(this.Vizitka, "Vizitka");
			this.Vizitka.BackgroundImage = null;
			this.Vizitka.Controls.Add(this.tableLayoutPanel);
			this.Vizitka.Font = null;
			this.Vizitka.Name = "Vizitka";
			this.Vizitka.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AccessibleDescription = null;
			this.tableLayoutPanel.AccessibleName = null;
			resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
			this.tableLayoutPanel.BackgroundImage = null;
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelVersion, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 0, 4);
			this.tableLayoutPanel.Font = null;
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			// 
			// labelProductName
			// 
			this.labelProductName.AccessibleDescription = null;
			this.labelProductName.AccessibleName = null;
			resources.ApplyResources(this.labelProductName, "labelProductName");
			this.labelProductName.Font = null;
			this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelProductName.Name = "labelProductName";
			// 
			// labelVersion
			// 
			this.labelVersion.AccessibleDescription = null;
			this.labelVersion.AccessibleName = null;
			resources.ApplyResources(this.labelVersion, "labelVersion");
			this.labelVersion.Font = null;
			this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelVersion.Name = "labelVersion";
			// 
			// labelCopyright
			// 
			this.labelCopyright.AccessibleDescription = null;
			this.labelCopyright.AccessibleName = null;
			resources.ApplyResources(this.labelCopyright, "labelCopyright");
			this.labelCopyright.Font = null;
			this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelCopyright.Name = "labelCopyright";
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.AccessibleDescription = null;
			this.labelCompanyName.AccessibleName = null;
			resources.ApplyResources(this.labelCompanyName, "labelCompanyName");
			this.labelCompanyName.Font = null;
			this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelCompanyName.Name = "labelCompanyName";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.AccessibleDescription = null;
			this.textBoxDescription.AccessibleName = null;
			resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
			this.textBoxDescription.BackgroundImage = null;
			this.textBoxDescription.Font = null;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.ReadOnly = true;
			this.textBoxDescription.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AccessibleDescription = null;
			this.tableLayoutPanel1.AccessibleName = null;
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.BackgroundImage = null;
			this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Obvestila, 0, 1);
			this.tableLayoutPanel1.Font = null;
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// shrani
			// 
			resources.ApplyResources(this.shrani, "shrani");
			// 
			// Program
			// 
			this.AccessibleDescription = null;
			this.AccessibleName = null;
			resources.ApplyResources(this, "$this");
			this.BackgroundImage = null;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = null;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Program";
			this.Load += new System.EventHandler(this.ob_zagonu);
			this.tabControl1.ResumeLayout(false);
			this.Glavno.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.Varovalke.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Nastavitve.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.Vizitka.ResumeLayout(false);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
        }
        private System.Windows.Forms.OpenFileDialog izbira;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Glavno;
        private System.Windows.Forms.TabPage Varovalke;
        private System.Windows.Forms.TabPage Vizitka;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel povezava_do_kalkulatorja;
        private System.Windows.Forms.TextBox lfuse_vrstica;
        private System.Windows.Forms.Button preberi_varovalke;
        private System.Windows.Forms.TextBox lockb_vrstica;
        private System.Windows.Forms.TextBox efuse_vrstica;
        private System.Windows.Forms.Button zapiši_varovalke;
        private System.Windows.Forms.TextBox hfuse_vrstica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Nastavitve;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.ComboBox progsel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox micsel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button FLASH_P;
        private System.Windows.Forms.Button zap_gumb_flash;
        private System.Windows.Forms.Button EPROM_P;
        private System.Windows.Forms.Button zap_gumb_eprom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button FLASH;
        private System.Windows.Forms.Button EPROM;
        private System.Windows.Forms.TextBox Obvestila;
        private System.Windows.Forms.SaveFileDialog shrani;
        private System.Windows.Forms.CheckBox port_check;
	}
}
