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
	partial class MainForm : System.Windows.Forms.Form
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
            this.izbira = new System.Windows.Forms.OpenFileDialog();
            this.izberi_hex = new System.Windows.Forms.Button();
            this.zapiši_varovalke = new System.Windows.Forms.Button();
            this.zapiši_hex = new System.Windows.Forms.Button();
            this.povezava_gumb = new System.Windows.Forms.Button();
            this.izbira_cipa = new System.Windows.Forms.ComboBox();
            this.lfuse_vrstica = new System.Windows.Forms.TextBox();
            this.hfuse_vrstica = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.preberi_varovalke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.povezava_do_kalkulatorja = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izberi_hex
            // 
            this.izberi_hex.Enabled = false;
            this.izberi_hex.Location = new System.Drawing.Point(12, 137);
            this.izberi_hex.Name = "izberi_hex";
            this.izberi_hex.Size = new System.Drawing.Size(100, 23);
            this.izberi_hex.TabIndex = 0;
            this.izberi_hex.Text = "Izberi program";
            this.izberi_hex.UseVisualStyleBackColor = true;
            this.izberi_hex.Click += new System.EventHandler(this.izberi_hex_Click);
            // 
            // zapiši_varovalke
            // 
            this.zapiši_varovalke.Enabled = false;
            this.zapiši_varovalke.Location = new System.Drawing.Point(126, 41);
            this.zapiši_varovalke.Name = "zapiši_varovalke";
            this.zapiši_varovalke.Size = new System.Drawing.Size(75, 23);
            this.zapiši_varovalke.TabIndex = 1;
            this.zapiši_varovalke.Text = "Zapiši";
            this.zapiši_varovalke.UseVisualStyleBackColor = true;
            this.zapiši_varovalke.Click += new System.EventHandler(this.zapiši_varovalke_Click);
            // 
            // zapiši_hex
            // 
            this.zapiši_hex.Enabled = false;
            this.zapiši_hex.Location = new System.Drawing.Point(126, 137);
            this.zapiši_hex.Name = "zapiši_hex";
            this.zapiši_hex.Size = new System.Drawing.Size(100, 23);
            this.zapiši_hex.TabIndex = 2;
            this.zapiši_hex.Text = "Zapiši program";
            this.zapiši_hex.UseVisualStyleBackColor = true;
            this.zapiši_hex.Click += new System.EventHandler(this.zapiši_hex_Click);
            // 
            // povezava_gumb
            // 
            this.povezava_gumb.Enabled = false;
            this.povezava_gumb.Location = new System.Drawing.Point(151, 12);
            this.povezava_gumb.Name = "povezava_gumb";
            this.povezava_gumb.Size = new System.Drawing.Size(75, 23);
            this.povezava_gumb.TabIndex = 3;
            this.povezava_gumb.Text = "Poveži";
            this.povezava_gumb.UseVisualStyleBackColor = true;
            this.povezava_gumb.Click += new System.EventHandler(this.povezava_gumb_Click);
            // 
            // izbira_cipa
            // 
            this.izbira_cipa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.izbira_cipa.FormattingEnabled = true;
            this.izbira_cipa.Items.AddRange(new object[] {
            "1200 at90s1200",
            "2313 at90s2313",
            "2333 at90s2333",
            "2343 at90s2343",
            "4414 at90s4414",
            "4433 at90s4433",
            "4434 at90s4434",
            "8515 at90s8515",
            "8535 at90s8535",
            "c128 at90can128",
            "m103 atmega103",
            "m128 atmega128",
            "m1280 atmega1280",
            "m1281 atmega1281",
            "m16 atmega16",
            "m161 atmega161",
            "m162 atmega162",
            "m163 atmega163",
            "m164 atmega164",
            "m168 atmega168",
            "m169 atmega169",
            "m2560 atmega2560",
            "m2561 atmega2561",
            "m32 atmega32",
            "m324 atmega324",
            "m325 atmega325",
            "m3250 atmega3250",
            "m329 atmega329",
            "m3290 atmega3290",
            "m48 atmega48",
            "m64 atmega64",
            "m640 atmega640",
            "m644 atmega644",
            "m645 atmega645",
            "m6450 atmega6450",
            "m649 atmega649",
            "m6490 atmega6490",
            "m8 ATmega8",
            "m8515 atmega8515",
            "m8535 atmega8535",
            "m88 atmega88",
            "pwm2 at90pwm2",
            "pwm3 at90pwm3",
            "t12 attiny12",
            "t13 attiny13",
            "t15 attiny15",
            "t2313 attiny2313",
            "t2313 attiny2313",
            "t24 attiny24",
            "t25 attiny25",
            "t26 attiny26",
            "t261 attiny261",
            "t44 attiny44",
            "t45 attiny45",
            "t461 attiny461",
            "t84 attiny84",
            "t85 attiny85",
            "usb1286 at90usb1286",
            "usb1287 at90usb1287",
            "usb646 at90usb646",
            "usb647 at90usb647"});
            this.izbira_cipa.Location = new System.Drawing.Point(12, 12);
            this.izbira_cipa.Name = "izbira_cipa";
            this.izbira_cipa.Size = new System.Drawing.Size(125, 21);
            this.izbira_cipa.Sorted = true;
            this.izbira_cipa.TabIndex = 4;
            this.izbira_cipa.SelectionChangeCommitted += new System.EventHandler(this.preveri);
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
            // hfuse_vrstica
            // 
            this.hfuse_vrstica.Enabled = false;
            this.hfuse_vrstica.Location = new System.Drawing.Point(35, 43);
            this.hfuse_vrstica.MaxLength = 2;
            this.hfuse_vrstica.Name = "hfuse_vrstica";
            this.hfuse_vrstica.Size = new System.Drawing.Size(24, 20);
            this.hfuse_vrstica.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(232, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(324, 148);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Ta program je namenjen programiranju, mikrokrmilnikov podjetja AMTMEL. ZA njegovo" +
                " uporabo morate najprej izbrati mikrokrmilnik. Avtor Janez Troha!";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "lfuse";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "hfuse";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(96, 16);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(24, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(65, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "efuse";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(96, 43);
            this.textBox5.MaxLength = 2;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(24, 20);
            this.textBox5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(65, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "lockb";
            // 
            // preberi_varovalke
            // 
            this.preberi_varovalke.Enabled = false;
            this.preberi_varovalke.Location = new System.Drawing.Point(126, 14);
            this.preberi_varovalke.Name = "preberi_varovalke";
            this.preberi_varovalke.Size = new System.Drawing.Size(75, 23);
            this.preberi_varovalke.TabIndex = 14;
            this.preberi_varovalke.Text = "Preberi";
            this.preberi_varovalke.UseVisualStyleBackColor = true;
            this.preberi_varovalke.Click += new System.EventHandler(this.preberi_varovalke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.povezava_do_kalkulatorja);
            this.groupBox1.Controls.Add(this.lfuse_vrstica);
            this.groupBox1.Controls.Add(this.preberi_varovalke);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.zapiši_varovalke);
            this.groupBox1.Controls.Add(this.hfuse_vrstica);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 92);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varovalke";
            // 
            // povezava_do_kalkulatorja
            // 
            this.povezava_do_kalkulatorja.AutoSize = true;
            this.povezava_do_kalkulatorja.Enabled = false;
            this.povezava_do_kalkulatorja.Location = new System.Drawing.Point(7, 73);
            this.povezava_do_kalkulatorja.Name = "povezava_do_kalkulatorja";
            this.povezava_do_kalkulatorja.Size = new System.Drawing.Size(118, 13);
            this.povezava_do_kalkulatorja.TabIndex = 15;
            this.povezava_do_kalkulatorja.TabStop = true;
            this.povezava_do_kalkulatorja.Text = "Kalkulator za varovalke";
            this.povezava_do_kalkulatorja.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(568, 172);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.izbira_cipa);
            this.Controls.Add(this.povezava_gumb);
            this.Controls.Add(this.zapiši_hex);
            this.Controls.Add(this.izberi_hex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AVRdude GUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button preberi_varovalke;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox hfuse_vrstica;
		private System.Windows.Forms.TextBox lfuse_vrstica;
		private System.Windows.Forms.ComboBox izbira_cipa;
		private System.Windows.Forms.Button povezava_gumb;
		private System.Windows.Forms.Button zapiši_hex;
		private System.Windows.Forms.Button zapiši_varovalke;
		private System.Windows.Forms.Button izberi_hex;
		private System.Windows.Forms.OpenFileDialog izbira;
        private System.Windows.Forms.LinkLabel povezava_do_kalkulatorja;
	}
}
