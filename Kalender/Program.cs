using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender
{
    class Program
    {

        static void Main()
        {
            Console.Write("C:> ");
            string Eingabe_des_Nutzer = Console.ReadLine();
            string[] Getrente_Eingabe_des_Nutzers = Trenung(Eingabe_des_Nutzer);
            Console.Write(Monat(Eingabe_des_Nutzer)); Console.WriteLine(Getrente_Eingabe_des_Nutzers[2]);
            Console.WriteLine(Kalender_of_Duty(Eingabe_des_Nutzer));
            //cal(Eingabe_des_Nutzer);
            //return Eingabe_des_Nutzer;
            Console.ReadLine();
        }

        internal static string[] Trenung(string Eingabe)
        {
            string[] eingabentrennung = new string[5];
            Eingabe = Eingabe + " ";
            eingabentrennung[0] = Eingabe.Substring(0, Eingabe.IndexOf(" "));
            Eingabe = Eingabe.Substring(Eingabe.IndexOf(" ") + 1);

            Eingabe = Eingabe + " ";
            eingabentrennung[1] = Eingabe.Substring(0, Eingabe.IndexOf(" "));
            Eingabe = Eingabe.Substring(Eingabe.IndexOf(" ") + 1);

            Eingabe = Eingabe + " ";
            eingabentrennung[2] = Eingabe.Substring(0, Eingabe.IndexOf(" "));
            Eingabe = Eingabe.Substring(Eingabe.IndexOf(" ") + 1);

            Eingabe = Eingabe + " ";
            eingabentrennung[3] = Eingabe.Substring(0, Eingabe.IndexOf(" "));
            Eingabe = Eingabe.Substring(Eingabe.IndexOf(" ") + 1);
            string[] getrente_eingabe = eingabentrennung;
            return getrente_eingabe;
        }

        internal static string Monat(string Eingabe)
        {
            string Monat;
            var Eingabe_des_Benutzers = Eingabe;
            if (Trenung(Eingabe_des_Benutzers)[1] == "1")
            { Monat = "Januar "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "2")
            { Monat = "Februar "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "3")
            { Monat = "März "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "4")
            { Monat = "April "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "5")
            { Monat = "Mai "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "6")
            { Monat = "Juni "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "7")
            { Monat = "Juli "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "8")
            { Monat = "August "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "9")
            { Monat = "September "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "10")
            { Monat = "Oktober "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "11")
            { Monat = "November "; }
            else if (Trenung(Eingabe_des_Benutzers)[1] == "12")
            { Monat = "Dezember "; }
            else
            {
                Monat = "";
            }
            return Monat;
        }
        internal static string Kalender_of_Duty(string Eingabe_des_Benutzers)
        {
            //var Eingabe_des_Benutzers = Program.Eingabe();
            string Wochentage; 
            if (Trenung(Eingabe_des_Benutzers)[3] == "Montag")
            {
                Wochentage = "Mo Di Mi Do Fr Sa So";
                return Wochentage;
            }
            else if (Trenung(Eingabe_des_Benutzers)[3] == "Dienstag")
            {
                Wochentage = "Di Mi Do Fr Sa So Mo";
                return Wochentage;
            }
            else if (Trenung(Eingabe_des_Benutzers)[3] == "Mittwoch")
            {
                Wochentage = "Mi Do Fr Sa So Mo Di";
                return Wochentage;
            }
            else if (Trenung(Eingabe_des_Benutzers)[3] == "Donnerstag")
            {
                Wochentage = "Do Fr Sa So Mo Di Mi";
                return Wochentage;
            }
            else if (Trenung(Eingabe_des_Benutzers)[3] == "Freitag")
            {
                Wochentage = "Fr Sa So Mo Di Mi Do";
                return Wochentage;
            }
            else if (Trenung(Eingabe_des_Benutzers)[3] == "Samstag" || Trenung(Eingabe_des_Benutzers)[3] == "Sonabend")
            {
                Wochentage = "Sa So Mo Di Mi Do Fr";
                return Wochentage;
            }
            else if (Trenung(Eingabe_des_Benutzers)[3] == "Sontag")
            {
                Wochentage = "So Mo Di Mi Do Fr Sa";
                return Wochentage;
            }
            else
            {
                Wochentage = "Mo Di Mi Do Fr Sa So";
            }
            return Wochentage;
        }
    
    }
}
