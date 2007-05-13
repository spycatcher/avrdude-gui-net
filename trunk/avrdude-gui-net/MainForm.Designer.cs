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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.izbira = new System.Windows.Forms.OpenFileDialog();
            this.izberi_hex = new System.Windows.Forms.Button();
            this.zapiši_varovalke = new System.Windows.Forms.Button();
            this.zapiši_hex = new System.Windows.Forms.Button();
            this.povezava_gumb = new System.Windows.Forms.Button();
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
            this.NASTAVITVE_gumb = new System.Windows.Forms.Button();
            this.VIZITKA_gumb = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // izberi_hex
            // 
            this.izberi_hex.Enabled = false;
            this.izberi_hex.Location = new System.Drawing.Point(77, 110);
            this.izberi_hex.Name = "izberi_hex";
            this.izberi_hex.Size = new System.Drawing.Size(82, 23);
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
            this.zapiši_varovalke.Size = new System.Drawing.Size(55, 23);
            this.zapiši_varovalke.TabIndex = 1;
            this.zapiši_varovalke.Text = "Zapiši";
            this.zapiši_varovalke.UseVisualStyleBackColor = true;
            this.zapiši_varovalke.Click += new System.EventHandler(this.zapiši_varovalke_Click);
            // 
            // zapiši_hex
            // 
            this.zapiši_hex.Enabled = false;
            this.zapiši_hex.Location = new System.Drawing.Point(165, 110);
            this.zapiši_hex.Name = "zapiši_hex";
            this.zapiši_hex.Size = new System.Drawing.Size(86, 23);
            this.zapiši_hex.TabIndex = 2;
            this.zapiši_hex.Text = "Zapiši program";
            this.zapiši_hex.UseVisualStyleBackColor = true;
            this.zapiši_hex.Click += new System.EventHandler(this.zapiši_hex_Click);
            // 
            // povezava_gumb
            // 
            this.povezava_gumb.Location = new System.Drawing.Point(12, 110);
            this.povezava_gumb.Name = "povezava_gumb";
            this.povezava_gumb.Size = new System.Drawing.Size(59, 23);
            this.povezava_gumb.TabIndex = 3;
            this.povezava_gumb.Text = "Poveži";
            this.povezava_gumb.UseVisualStyleBackColor = true;
            this.povezava_gumb.Click += new System.EventHandler(this.povezava_gumb_Click);
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
            this.textBox3.Location = new System.Drawing.Point(211, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(262, 92);
            this.textBox3.TabIndex = 7;
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
            this.preberi_varovalke.Size = new System.Drawing.Size(55, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 92);
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
            // NASTAVITVE_gumb
            // 
            this.NASTAVITVE_gumb.Location = new System.Drawing.Point(320, 110);
            this.NASTAVITVE_gumb.Name = "NASTAVITVE_gumb";
            this.NASTAVITVE_gumb.Size = new System.Drawing.Size(72, 23);
            this.NASTAVITVE_gumb.TabIndex = 16;
            this.NASTAVITVE_gumb.Text = "Nastavitve";
            this.NASTAVITVE_gumb.UseVisualStyleBackColor = true;
            this.NASTAVITVE_gumb.Click += new System.EventHandler(this.NASTAVITVE_gumb_Click);
            // 
            // VIZITKA_gumb
            // 
            this.VIZITKA_gumb.Location = new System.Drawing.Point(398, 110);
            this.VIZITKA_gumb.Name = "VIZITKA_gumb";
            this.VIZITKA_gumb.Size = new System.Drawing.Size(75, 23);
            this.VIZITKA_gumb.TabIndex = 17;
            this.VIZITKA_gumb.Text = "Vizitka";
            this.VIZITKA_gumb.UseVisualStyleBackColor = true;
            this.VIZITKA_gumb.Click += new System.EventHandler(this.VIZITKA_gumb_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(485, 141);
            this.Controls.Add(this.VIZITKA_gumb);
            this.Controls.Add(this.NASTAVITVE_gumb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.povezava_gumb);
            this.Controls.Add(this.zapiši_hex);
            this.Controls.Add(this.izberi_hex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
		private System.Windows.Forms.Button povezava_gumb;
		private System.Windows.Forms.Button zapiši_hex;
		private System.Windows.Forms.Button zapiši_varovalke;
		private System.Windows.Forms.Button izberi_hex;
		private System.Windows.Forms.OpenFileDialog izbira;
        private System.Windows.Forms.LinkLabel povezava_do_kalkulatorja;
        private System.Windows.Forms.Button NASTAVITVE_gumb;
        private System.Windows.Forms.Button VIZITKA_gumb;
	}
}
