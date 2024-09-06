using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class Person
    {
        //Konstanten
        public const int MAENNLICH = 0;
        public const int WEIBLICH = 1;
        private const double ABBAU_WARZETEIT_STUNDEN = 1.0;
        private const double ABBAU_PRO_STUNDE = 0.1;
        private const double ANTEIL_WASSER_IM_BLUT = 0.8;
        private const double DICHTE_BLUT_GRAMM_PRO_CCM = 1.055;
       
        //Field
        private double _koepermasse;
        private double _koepergroesseInCm;
        private DateTime _geburtsdatum;
        private int _geschlecht;
        private double _alkoholPromille = 0.0;

        //propetry 
        public double AlterInJahre 
        { 
            get
            {
                DateTime heute = DateTime.Now;
                int alter = heute.Year - _geburtsdatum.Year;
                if (heute.Month > _geburtsdatum.Month)
                {
                    alter++;
                }
                return alter;
            }
        }

        public double AlkoholPromille
        { 
           get
            {
                return _alkoholPromille;
            }

        } 
        public double GKW
        { 
            get
            {
                if (_geschlecht == MAENNLICH)
                {
                    return 2.447 - 0.09616 * AlterInJahre + 0.1074 * _koepergroesseInCm + 0.3362 * _koepermasse;
                }
                else
                {
                    return 0.203 - 0.07 * AlterInJahre + 0.1069 * _koepergroesseInCm + 02466 * _koepermasse;
                }
            }
        } 

        //Konstruktor
        public Person(double koerpermasse, double koerpergroesseInCm, DateTime geburtsdaum, int geschlecht)
        {
            _koepermasse = koerpermasse;
            _koepergroesseInCm = koerpergroesseInCm;
            _geburtsdatum = geburtsdaum;
            _geschlecht = geschlecht;
        }

        //Methode
        public void Trinke(Getraenk getraenk)
        {
            _alkoholPromille = (ANTEIL_WASSER_IM_BLUT * getraenk.AlkoholmasseInGramm) / (DICHTE_BLUT_GRAMM_PRO_CCM * GKW);
            _alkoholPromille -= (getraenk.StundenSeitEinnahme - ABBAU_WARZETEIT_STUNDEN) * ABBAU_PRO_STUNDE;

        }


    }
}
