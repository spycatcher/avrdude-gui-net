using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Nastavitve;
using avrdudegui.Orodja;
namespace avrdudegui
{
    public partial class Nastavitve
    {


        public Nastavitve()
        {
            InitializeComponent();
            Vrednosti.Odpri();
            parsenastavitve();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Vrednosti.Mikrokontroler = micsel.Items[micsel.SelectedIndex].ToString();
            Vrednosti.Programator = progsel.Items[progsel.SelectedIndex].ToString();
            Vrednosti.Port = Port.Text;
            Vrednosti.Shrani();
        }

        void parsenastavitve()
        {
            micsel.Items.Clear();
            progsel.Items.Clear();
            string[] data = Pripomoèki.Zagon("-c test").Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in data)
            {
                progsel.Items.Add(s.Replace(" ", "").Split('=')[0]);
            }
            progsel.Items.RemoveAt(0);
            progsel.Items.RemoveAt(0);
            progsel.Sorted = true;
            progsel.Refresh();
            progsel.SelectedIndex = progsel.Items.IndexOf(Vrednosti.Programator);
            data = Pripomoèki.Zagon("-c " + Vrednosti.Programator).Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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
        
    }

}
