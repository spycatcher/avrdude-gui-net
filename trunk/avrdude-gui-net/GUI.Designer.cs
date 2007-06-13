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
	partial class GUI : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.izbira = new System.Windows.Forms.OpenFileDialog();
            this.meni = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.epromToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.writeFlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeEpromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.readFlashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readEpromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.readAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fusesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportedProgrammersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suportedDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meni.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // izbira
            // 
            this.izbira.Filter = "Intel Hex (*.hex)|*.hex|Motorola S-Record (*.rom)|*.rom|Bin (*.bin)|*.bin|Vse dat" +
                "oteke (*.*)|*.*";
            this.izbira.Title = "Izberi datoteko ki jo želiš zapisati";
            // 
            // meni
            // 
            this.meni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.meni.Location = new System.Drawing.Point(0, 0);
            this.meni.Name = "meni";
            this.meni.Size = new System.Drawing.Size(402, 24);
            this.meni.TabIndex = 18;
            this.meni.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flashToolStripMenuItem,
            this.epromToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            // 
            // flashToolStripMenuItem
            // 
            this.flashToolStripMenuItem.Name = "flashToolStripMenuItem";
            this.flashToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.flashToolStripMenuItem.Text = "Flash";
            // 
            // epromToolStripMenuItem
            // 
            this.epromToolStripMenuItem.Name = "epromToolStripMenuItem";
            this.epromToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.epromToolStripMenuItem.Text = "Eprom";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flashToolStripMenuItem1,
            this.epromToolStripMenuItem1});
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.saveFileToolStripMenuItem.Text = "Save file";
            // 
            // flashToolStripMenuItem1
            // 
            this.flashToolStripMenuItem1.Name = "flashToolStripMenuItem1";
            this.flashToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.flashToolStripMenuItem1.Text = "Flash";
            // 
            // epromToolStripMenuItem1
            // 
            this.epromToolStripMenuItem1.Name = "epromToolStripMenuItem1";
            this.epromToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.epromToolStripMenuItem1.Text = "Eprom";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Izhod_klik);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripSeparator4,
            this.writeFlashToolStripMenuItem,
            this.writeEpromToolStripMenuItem,
            this.toolStripSeparator2,
            this.readFlashToolStripMenuItem,
            this.readEpromToolStripMenuItem,
            this.toolStripSeparator3,
            this.readAllToolStripMenuItem,
            this.writeAllToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.povezava_gumb_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // writeFlashToolStripMenuItem
            // 
            this.writeFlashToolStripMenuItem.Name = "writeFlashToolStripMenuItem";
            this.writeFlashToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.writeFlashToolStripMenuItem.Text = "Write Flash";
            // 
            // writeEpromToolStripMenuItem
            // 
            this.writeEpromToolStripMenuItem.Name = "writeEpromToolStripMenuItem";
            this.writeEpromToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.writeEpromToolStripMenuItem.Text = "Write Eprom";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // readFlashToolStripMenuItem
            // 
            this.readFlashToolStripMenuItem.Name = "readFlashToolStripMenuItem";
            this.readFlashToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.readFlashToolStripMenuItem.Text = "Read Flash";
            // 
            // readEpromToolStripMenuItem
            // 
            this.readEpromToolStripMenuItem.Name = "readEpromToolStripMenuItem";
            this.readEpromToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.readEpromToolStripMenuItem.Text = "Read Eprom";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // readAllToolStripMenuItem
            // 
            this.readAllToolStripMenuItem.Name = "readAllToolStripMenuItem";
            this.readAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.readAllToolStripMenuItem.Text = "Read all";
            // 
            // writeAllToolStripMenuItem
            // 
            this.writeAllToolStripMenuItem.Name = "writeAllToolStripMenuItem";
            this.writeAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.writeAllToolStripMenuItem.Text = "Write all";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.fusesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.NASTAVITVE_gumb_Click);
            // 
            // fusesToolStripMenuItem
            // 
            this.fusesToolStripMenuItem.Name = "fusesToolStripMenuItem";
            this.fusesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fusesToolStripMenuItem.Text = "Fuses";
            this.fusesToolStripMenuItem.Click += new System.EventHandler(this.fusesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.VIZITKA_gumb_Click);
            // 
            // status
            // 
            this.status.AllowMerge = false;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.status.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.status.Location = new System.Drawing.Point(0, 154);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(402, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 19;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Visible = false;
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportedProgrammersToolStripMenuItem,
            this.suportedDevicesToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // supportedProgrammersToolStripMenuItem
            // 
            this.supportedProgrammersToolStripMenuItem.Name = "supportedProgrammersToolStripMenuItem";
            this.supportedProgrammersToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.supportedProgrammersToolStripMenuItem.Text = "Supported programmers";
            this.supportedProgrammersToolStripMenuItem.Click += new System.EventHandler(this.supportedProgrammersToolStripMenuItem_Click);
            // 
            // suportedDevicesToolStripMenuItem
            // 
            this.suportedDevicesToolStripMenuItem.Name = "suportedDevicesToolStripMenuItem";
            this.suportedDevicesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.suportedDevicesToolStripMenuItem.Text = "Suported devices";
            // 
            // GUI
            // 
            this.ClientSize = new System.Drawing.Size(402, 176);
            this.Controls.Add(this.status);
            this.Controls.Add(this.meni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.meni;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVRdude GUI";
            this.Load += new System.EventHandler(this.ob_zagonu);
            this.meni.ResumeLayout(false);
            this.meni.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.OpenFileDialog izbira;
        private System.Windows.Forms.MenuStrip meni;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem epromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flashToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem epromToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeFlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeEpromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem readFlashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readEpromToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem readAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem fusesToolStripMenuItem;
        public  System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportedProgrammersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suportedDevicesToolStripMenuItem;
	}
}
