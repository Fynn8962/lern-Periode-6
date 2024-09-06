using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class Getraenk
    {
        //Konstanten
        public const double BIER_ALKOHOLGEHALT = 0.05;
        public const double WEIN_ALKOHOLGEHALT = 0.10;
        public const double SCHANPS_ALKOHOLGEHALT = 0.40;
        public const double DICHTE_ALKOHOL = 0.8;

        //Filed
        private int _volumenInMilliliter;
        private double _alkoholgehalt;
        private DateTime _getrunkenAm;

        //Property
        public double StundenSeitEinnahme
        {
            get
            {
                DateTime heute = DateTime.Now;
                return heute.Hour - _getrunkenAm.Hour;
            }
        }
        
        public double AlkoholmasseInGramm
        {
            get {
                return _volumenInMilliliter* _alkoholgehalt *DICHTE_ALKOHOL;
                }
        }

        //Konstruktor
        public Getraenk(int volumenInMilliliter, double alkoholgehalt, DateTime getrunkenAm)
        {
            _volumenInMilliliter = volumenInMilliliter;
            _alkoholgehalt = alkoholgehalt;
            _getrunkenAm = getrunkenAm;

        }


    }
}
