using System;
using System.Collections;
using System.Text;
using Nastavitve;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

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
                Odpri();
                return Mikrokontroler_n;
            }
            set
            {
                Mikrokontroler_n = value;
                Shrani();
            }
        }

        public static string Port
        {
            get
            {
                Odpri();
                return Port_n;
            }
            set
            {
                Port_n = value;
                Shrani();
            }
        }

        public static string Programator
        {
            get
            {
                Odpri();
                return Programator_n;
            }
            set
            {
                Programator_n = value;
                Shrani();
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
            Mikrokontroler_n = settings.GetSetting("Mikrokontroler", "m8 ATMEGA8");
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
            Console.WriteLine(vukaz);
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
                //.AppendText("Ukazni niz: avrdude " + vukaz + Environment.NewLine + Environment.NewLine);
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

        public static string AssemblyTitle
        {
            get
            {
                // Get all Title attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // If there is at least one Title attribute
                if (attributes.Length > 0)
                {
                    // Select the first one
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // If it is not an empty string, return it
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyDescription
        {
            get
            {
                // Get all Description attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // If there aren't any Description attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Description attribute, return its value
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                // Get all Product attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // If there aren't any Product attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Product attribute, return its value
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                // Get all Copyright attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // If there aren't any Copyright attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Copyright attribute, return its value
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                // Get all Company attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // If there aren't any Company attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Company attribute, return its value
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
    }

}
