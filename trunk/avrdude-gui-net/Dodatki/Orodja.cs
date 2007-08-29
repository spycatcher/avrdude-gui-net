using System;
using System.Collections;
using System.Text;
using Nastavitve;
using System.Windows.Forms;
using System.Diagnostics;

namespace avrdudegui.Orodja
{
    public static class Vrednosti
    {
        static string Mikrokontroler_n;
        static string Port_n;
        static string Programator_n;
        static string Avrdude_pot_n;
        static string Spletna_stran_n;
        static string Datoteka_hex_n;

        public static string Datoteka_hex
        {
            get
            {
                return Datoteka_hex_n;
            }
            set
            {
                Datoteka_hex_n = value;
            }
        }

        public static string Mikrokontroler
        {
            get
            {
                return Mikrokontroler_n;
            }
            set
            {
                Mikrokontroler_n = value;
            }
        }

        public static string Port
        {
            get
            {
                return Port_n;
            }
            set
            {
                Port_n = value;
            }
        }

        public static string Programator
        {
            get
            {
                return Programator_n;
            }
            set
            {
                Programator_n = value;
            }
        }

        public static string Avrdude_pot
        {
            get
            {
                return Avrdude_pot_n;
            }
            set
            {
                Avrdude_pot_n = value;
            }
        }

        public static string Spletna_stran
        {
            get
            {
                return Spletna_stran_n;
            }
            set
            {
                Spletna_stran_n = value;
            }
        }

        public static void Odpri()
        {
            SettingsFile.Create(Application.StartupPath + @"\nastavitve.xml");
            SettingsKey settings = SettingsFile.Settings["Program"];
            Mikrokontroler_n = settings.GetSetting("Mikrokontroler", "m8");
            Programator_n = settings.GetSetting("Programator", "usbasp");
            Port_n = settings.GetSetting("Port", "USB");
        }

        internal static void Shrani()
        {
            SettingsKey settings = SettingsFile.Settings["Program"];
            settings.StoreSetting("Mikrokontroler", Mikrokontroler_n);
            settings.StoreSetting("Programator", Programator_n);
            settings.StoreSetting("Port", Port_n);
            SettingsFile.Update();
        }
    }
    public static class Pripomoèki
    {
        static string error,standard;

        internal static string Zagon(string vukaz)
        {
            Process run = new System.Diagnostics.Process();
            try
            {
                run.StartInfo.FileName = Vrednosti.Avrdude_pot;
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
                //textBox3.AppendText("Ukazni niz: avrdude " + vukaz + Environment.NewLine + Environment.NewLine);
                //textBox3.AppendText(standard.Replace("avrdude.exe: safemode:", ""));
                //textBox3.AppendText(error.Replace("avrdude.exe", "").Replace(", or use -F to override this check", "").Replace(":", ""));
                if (error.Contains("AVR device initialized and ready to accept instructions") & error.Contains("error programm enable"))
                {
                }
                return error.Replace("avrdude.exe", "");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.Message.ToString();
            }
        }
    }

}
