using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class PromilleRechner
    {
        //Methoden
        private Person FragePersonenDaten()
        {
            Console.WriteLine("Männlich[0] oder Weiblich[1] -> ");
            int geschlecht = int.Parse(Console.ReadLine());
            Console.WriteLine("Gewicht in kg -> ");
            int gewicht = int.Parse(Console.ReadLine());
            Console.WriteLine("Körpergrösse  in cm-> ");
            int groesse = int.Parse(Console.ReadLine());
            Console.WriteLine("Geburtsdatum -> ");
            DateTime geburtstag;
            DateTime.TryParse(Console.ReadLine(), out geburtstag);

            return new Person(gewicht, groesse, geburtstag, geschlecht);
        }

        private Getraenk FrageGetraenkeDaten()
        {
            Console.WriteLine("welches Getänk?\tBIER[1]\tWEIN[2]\tSCHNAPS[3]");
            int getraenk = int.Parse(Console.ReadLine());
            double alkoholgehalt = 0;
            switch (getraenk)
            {
                case 1:
                    alkoholgehalt = Getraenk.BIER_ALKOHOLGEHALT;
                    break;
                case 2:
                    alkoholgehalt = Getraenk.WEIN_ALKOHOLGEHALT;
                    break;
                case 3:
                    alkoholgehalt = Getraenk.SCHANPS_ALKOHOLGEHALT;
                    break;
            }
            Console.WriteLine("Milliliter ->");
            int volumenInMilliliter = int.Parse(Console.ReadLine());
            Console.WriteLine("Getrunken um[DD.MM.YYYY HH:mm] ->");
            DateTime getrunkenAm;
            DateTime.TryParse(Console.ReadLine(), out getrunkenAm);

            return new Getraenk(volumenInMilliliter, alkoholgehalt, getrunkenAm);

        }

        public void BerechnePromille()
        {
            Person person = FragePersonenDaten();
            Getraenk getraenk = FrageGetraenkeDaten();
            person.Trinke(getraenk);
            Console.WriteLine("Promillewert=" + person.AlkoholPromille);
            Spruch spruch = new Spruch(person.AlkoholPromille);
            Console.WriteLine(spruch.ErhalteSpruch());
        }
    }
}
