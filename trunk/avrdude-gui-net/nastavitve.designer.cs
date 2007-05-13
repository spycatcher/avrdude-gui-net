namespace avrdudegui.Nastavitve
{
    partial class nastavitve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progsel = new System.Windows.Forms.ComboBox();
            this.Preklièi = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.micsel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.progsel.Size = new System.Drawing.Size(248, 21);
            this.progsel.TabIndex = 3;
            // 
            // Preklièi
            // 
            this.Preklièi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Preklièi.Location = new System.Drawing.Point(281, 57);
            this.Preklièi.Name = "Preklièi";
            this.Preklièi.Size = new System.Drawing.Size(75, 23);
            this.Preklièi.TabIndex = 4;
            this.Preklièi.Text = "Preklièi";
            this.Preklièi.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Location = new System.Drawing.Point(281, 86);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
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
            this.micsel.Size = new System.Drawing.Size(248, 21);
            this.micsel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progsel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 49);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programator";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.micsel);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 49);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mikrokontroler";
            // 
            // nastavitve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 124);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Preklièi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "nastavitve";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nastavitve";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox progsel;
        private System.Windows.Forms.Button Preklièi;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox micsel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}