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
            this.izbira.Filter = "Intel Hex (*.hex)|*.hex|Motorola S-Record (*.rom)|*.rom|Bin (*.bin)|*.bin";
            this.izbira.Title = "Izberi datoteko ki jo želiš zapisati";
            // 
            // Obvestila
            // 
            this.Obvestila.AccessibleDescription = "Obvestila za uporabnika";
            this.Obvestila.AccessibleName = "Obvestilo";
            this.Obvestila.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.Obvestila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Obvestila.Location = new System.Drawing.Point(3, 172);
            this.Obvestila.Multiline = true;
            this.Obvestila.Name = "Obvestila";
            this.Obvestila.ReadOnly = true;
            this.Obvestila.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Obvestila.Size = new System.Drawing.Size(293, 67);
            this.Obvestila.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Glavno);
            this.tabControl1.Controls.Add(this.Varovalke);
            this.tabControl1.Controls.Add(this.Nastavitve);
            this.tabControl1.Controls.Add(this.Vizitka);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 163);
            this.tabControl1.TabIndex = 21;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.spremembapoložaja);
            // 
            // Glavno
            // 
            this.Glavno.Controls.Add(this.tableLayoutPanel3);
            this.Glavno.Location = new System.Drawing.Point(4, 22);
            this.Glavno.Name = "Glavno";
            this.Glavno.Padding = new System.Windows.Forms.Padding(3);
            this.Glavno.Size = new System.Drawing.Size(285, 137);
            this.Glavno.TabIndex = 0;
            this.Glavno.Text = "Flash & Eprom";
            this.Glavno.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(279, 131);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FLASH);
            this.groupBox4.Controls.Add(this.FLASH_P);
            this.groupBox4.Controls.Add(this.zap_gumb_flash);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 59);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flash";
            // 
            // FLASH
            // 
            this.FLASH.Location = new System.Drawing.Point(6, 19);
            this.FLASH.Name = "FLASH";
            this.FLASH.Size = new System.Drawing.Size(99, 23);
            this.FLASH.TabIndex = 3;
            this.FLASH.Text = "Izberi datoteko";
            this.FLASH.UseVisualStyleBackColor = true;
            this.FLASH.Click += new System.EventHandler(this.izberi_datoteko_Click);
            // 
            // FLASH_P
            // 
            this.FLASH_P.Location = new System.Drawing.Point(192, 19);
            this.FLASH_P.Name = "FLASH_P";
            this.FLASH_P.Size = new System.Drawing.Size(75, 23);
            this.FLASH_P.TabIndex = 2;
            this.FLASH_P.Text = "Preberi";
            this.FLASH_P.UseVisualStyleBackColor = true;
            this.FLASH_P.Click += new System.EventHandler(this.preberi_pomnilnik_Click);
            // 
            // zap_gumb_flash
            // 
            this.zap_gumb_flash.Enabled = false;
            this.zap_gumb_flash.Location = new System.Drawing.Point(111, 19);
            this.zap_gumb_flash.Name = "zap_gumb_flash";
            this.zap_gumb_flash.Size = new System.Drawing.Size(75, 23);
            this.zap_gumb_flash.TabIndex = 1;
            this.zap_gumb_flash.Text = "Zapiši";
            this.zap_gumb_flash.UseVisualStyleBackColor = true;
            this.zap_gumb_flash.Click += new System.EventHandler(this.zapiši_POMINLNIK_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EPROM);
            this.groupBox5.Controls.Add(this.EPROM_P);
            this.groupBox5.Controls.Add(this.zap_gumb_eprom);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 60);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eprom";
            // 
            // EPROM
            // 
            this.EPROM.Enabled = false;
            this.EPROM.Location = new System.Drawing.Point(6, 19);
            this.EPROM.Name = "EPROM";
            this.EPROM.Size = new System.Drawing.Size(99, 23);
            this.EPROM.TabIndex = 4;
            this.EPROM.Text = "Izberi datoteko";
            this.EPROM.UseVisualStyleBackColor = true;
            this.EPROM.Click += new System.EventHandler(this.izberi_datoteko_Click);
            // 
            // EPROM_P
            // 
            this.EPROM_P.Enabled = false;
            this.EPROM_P.Location = new System.Drawing.Point(192, 19);
            this.EPROM_P.Name = "EPROM_P";
            this.EPROM_P.Size = new System.Drawing.Size(75, 23);
            this.EPROM_P.TabIndex = 5;
            this.EPROM_P.Text = "Preberi";
            this.EPROM_P.UseVisualStyleBackColor = true;
            this.EPROM_P.Click += new System.EventHandler(this.preberi_pomnilnik_Click);
            // 
            // zap_gumb_eprom
            // 
            this.zap_gumb_eprom.Enabled = false;
            this.zap_gumb_eprom.Location = new System.Drawing.Point(111, 19);
            this.zap_gumb_eprom.Name = "zap_gumb_eprom";
            this.zap_gumb_eprom.Size = new System.Drawing.Size(75, 23);
            this.zap_gumb_eprom.TabIndex = 4;
            this.zap_gumb_eprom.Text = "Zapiši";
            this.zap_gumb_eprom.UseVisualStyleBackColor = true;
            this.zap_gumb_eprom.Click += new System.EventHandler(this.zapiši_POMINLNIK_Click);
            // 
            // Varovalke
            // 
            this.Varovalke.Controls.Add(this.groupBox1);
            this.Varovalke.Location = new System.Drawing.Point(4, 22);
            this.Varovalke.Name = "Varovalke";
            this.Varovalke.Padding = new System.Windows.Forms.Padding(3);
            this.Varovalke.Size = new System.Drawing.Size(285, 137);
            this.Varovalke.TabIndex = 1;
            this.Varovalke.Text = "Varovalke";
            this.Varovalke.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 131);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varovalke";
            // 
            // povezava_do_kalkulatorja
            // 
            this.povezava_do_kalkulatorja.AutoSize = true;
            this.povezava_do_kalkulatorja.Location = new System.Drawing.Point(7, 73);
            this.povezava_do_kalkulatorja.Name = "povezava_do_kalkulatorja";
            this.povezava_do_kalkulatorja.Size = new System.Drawing.Size(118, 13);
            this.povezava_do_kalkulatorja.TabIndex = 15;
            this.povezava_do_kalkulatorja.TabStop = true;
            this.povezava_do_kalkulatorja.Text = "Kalkulator za varovalke";
            this.povezava_do_kalkulatorja.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lfuse_vrstica
            // 
            this.lfuse_vrstica.Enabled = false;
            this.lfuse_vrstica.Location = new System.Drawing.Point(35, 16);
            this.lfuse_vrstica.MaxLength = 2;
            this.lfuse_vrstica.Name = "lfuse_vrstica";
            this.lfuse_vrstica.Size = new System.Drawing.Size(24, 20);
            this.lfuse_vrstica.TabIndex = 5;
            // 
            // preberi_varovalke
            // 
            this.preberi_varovalke.Location = new System.Drawing.Point(126, 14);
            this.preberi_varovalke.Name = "preberi_varovalke";
            this.preberi_varovalke.Size = new System.Drawing.Size(61, 23);
            this.preberi_varovalke.TabIndex = 14;
            this.preberi_varovalke.Text = "Preberi";
            this.preberi_varovalke.UseVisualStyleBackColor = true;
            this.preberi_varovalke.Click += new System.EventHandler(this.preberi_varovalke_Click);
            // 
            // lockb_vrstica
            // 
            this.lockb_vrstica.Enabled = false;
            this.lockb_vrstica.Location = new System.Drawing.Point(96, 43);
            this.lockb_vrstica.MaxLength = 2;
            this.lockb_vrstica.Name = "lockb_vrstica";
            this.lockb_vrstica.Size = new System.Drawing.Size(24, 20);
            this.lockb_vrstica.TabIndex = 12;
            // 
            // efuse_vrstica
            // 
            this.efuse_vrstica.Enabled = false;
            this.efuse_vrstica.Location = new System.Drawing.Point(96, 16);
            this.efuse_vrstica.MaxLength = 2;
            this.efuse_vrstica.Name = "efuse_vrstica";
            this.efuse_vrstica.Size = new System.Drawing.Size(24, 20);
            this.efuse_vrstica.TabIndex = 10;
            // 
            // zapiši_varovalke
            // 
            this.zapiši_varovalke.Enabled = false;
            this.zapiši_varovalke.Location = new System.Drawing.Point(126, 41);
            this.zapiši_varovalke.Name = "zapiši_varovalke";
            this.zapiši_varovalke.Size = new System.Drawing.Size(61, 23);
            this.zapiši_varovalke.TabIndex = 1;
            this.zapiši_varovalke.Text = "Zapiši";
            this.zapiši_varovalke.UseVisualStyleBackColor = true;
            this.zapiši_varovalke.Click += new System.EventHandler(this.zapiši_varovalke_Click);
            // 
            // hfuse_vrstica
            // 
            this.hfuse_vrstica.Enabled = false;
            this.hfuse_vrstica.Location = new System.Drawing.Point(35, 43);
            this.hfuse_vrstica.MaxLength = 2;
            this.hfuse_vrstica.Name = "hfuse_vrstica";
            this.hfuse_vrstica.Size = new System.Drawing.Size(24, 20);
            this.hfuse_vrstica.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(65, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "lockb";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(65, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "efuse";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "hfuse";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "lfuse";
            // 
            // Nastavitve
            // 
            this.Nastavitve.Controls.Add(this.tableLayoutPanel2);
            this.Nastavitve.Location = new System.Drawing.Point(4, 22);
            this.Nastavitve.Name = "Nastavitve";
            this.Nastavitve.Padding = new System.Windows.Forms.Padding(3);
            this.Nastavitve.Size = new System.Drawing.Size(285, 137);
            this.Nastavitve.TabIndex = 3;
            this.Nastavitve.Text = "Nastavitve";
            this.Nastavitve.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 131);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.port_check);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Port);
            this.groupBox3.Controls.Add(this.progsel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 70);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Programator";
            // 
            // port_check
            // 
            this.port_check.AutoSize = true;
            this.port_check.Checked = true;
            this.port_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.port_check.Location = new System.Drawing.Point(171, 47);
            this.port_check.Name = "port_check";
            this.port_check.Size = new System.Drawing.Size(92, 17);
            this.port_check.TabIndex = 6;
            this.port_check.Text = "Uporabim port";
            this.port_check.UseVisualStyleBackColor = true;
            this.port_check.CheckedChanged += new System.EventHandler(this.sprememba_porta);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port (USB, COM, LPT):";
            // 
            // Port
            // 
            this.Port.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Port.Location = new System.Drawing.Point(122, 46);
            this.Port.MaxLength = 100;
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(43, 20);
            this.Port.TabIndex = 4;
            this.Port.WordWrap = false;
            // 
            // progsel
            // 
            this.progsel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.progsel.FormattingEnabled = true;
            this.progsel.Items.AddRange(new object[] {
            "Daljinc",
            "anyRemote"});
            this.progsel.Location = new System.Drawing.Point(6, 19);
            this.progsel.Name = "progsel";
            this.progsel.Size = new System.Drawing.Size(261, 21);
            this.progsel.TabIndex = 3;
            this.progsel.SelectedIndexChanged += new System.EventHandler(this.supportedProgrammersToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.micsel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mikrokontroler";
            // 
            // micsel
            // 
            this.micsel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.micsel.FormattingEnabled = true;
            this.micsel.Items.AddRange(new object[] {
            "ghchghg",
            "gvjv",
            "teswt"});
            this.micsel.Location = new System.Drawing.Point(6, 19);
            this.micsel.Name = "micsel";
            this.micsel.Size = new System.Drawing.Size(261, 21);
            this.micsel.TabIndex = 0;
            this.micsel.SelectedIndexChanged += new System.EventHandler(this.suportedDevicesToolStripMenuItem_Click);
            // 
            // Vizitka
            // 
            this.Vizitka.Controls.Add(this.tableLayoutPanel);
            this.Vizitka.Location = new System.Drawing.Point(4, 22);
            this.Vizitka.Name = "Vizitka";
            this.Vizitka.Padding = new System.Windows.Forms.Padding(3);
            this.Vizitka.Size = new System.Drawing.Size(285, 137);
            this.Vizitka.TabIndex = 2;
            this.Vizitka.Text = "Vizitka";
            this.Vizitka.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.50388F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.58915F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(279, 131);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(6, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(391, 12);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(6, 12);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(391, 12);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(6, 24);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(391, 12);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName.Location = new System.Drawing.Point(6, 36);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(391, 17);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(0, 55);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(280, 76);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Obvestila, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // shrani
            // 
            this.shrani.Filter = "Intel Hex (*.hex)|*.hex|Motorola S-Record (*.rom)|*.rom|Bin (*.bin)|*.bin";
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(299, 242);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVRdude GUI";
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
