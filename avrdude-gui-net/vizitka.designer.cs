/*
 * Created by SharpDevelop.
 * User: Janez
 * Date: 21.8.2006
 * Time: 23:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace avrdudegui
{
	partial class vizitka : System.Windows.Forms.Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.Label();
            this.verzija = new System.Windows.Forms.Label();
            this.avtor = new System.Windows.Forms.Label();
            this.licenca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "V redu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zapri);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(14, 115);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(282, 91);
            this.textBoxDescription.TabIndex = 24;
            this.textBoxDescription.TabStop = false;
            // 
            // ime
            // 
            this.ime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ime.Location = new System.Drawing.Point(14, 14);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(282, 23);
            this.ime.TabIndex = 25;
            this.ime.Text = "Ime: ";
            // 
            // verzija
            // 
            this.verzija.Location = new System.Drawing.Point(14, 37);
            this.verzija.Name = "verzija";
            this.verzija.Size = new System.Drawing.Size(282, 23);
            this.verzija.TabIndex = 26;
            this.verzija.Text = "Verzija: ";
            // 
            // avtor
            // 
            this.avtor.Location = new System.Drawing.Point(14, 60);
            this.avtor.Name = "avtor";
            this.avtor.Size = new System.Drawing.Size(282, 23);
            this.avtor.TabIndex = 27;
            this.avtor.Text = "Avtor: ";
            // 
            // licenca
            // 
            this.licenca.Location = new System.Drawing.Point(14, 83);
            this.licenca.Name = "licenca";
            this.licenca.Size = new System.Drawing.Size(282, 23);
            this.licenca.TabIndex = 28;
            this.licenca.Text = "Licenca: ";
            // 
            // vizitka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.ControlBox = false;
            this.Controls.Add(this.licenca);
            this.Controls.Add(this.avtor);
            this.Controls.Add(this.verzija);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vizitka";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "O programu";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label licenca;
		private System.Windows.Forms.Label avtor;
		private System.Windows.Forms.Label verzija;
		private System.Windows.Forms.Label ime;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button button1;
		
		void TableLayoutPanel1Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
	}
}
