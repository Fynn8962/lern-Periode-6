using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promillerechner
{
    internal class Spruch
    {
        //Field
        private double _alkoholPromille;

        //Konstruktor
        public Spruch(double alkoholPromille)
        {
            _alkoholPromille = alkoholPromille;
        }

        //Methode
        public string ErhalteSpruch()
        {
            string spruch;
            if (_alkoholPromille <= 0)
            {
                spruch = "Alles ok, total nüchtern.";
            }
            else if (_alkoholPromille <= 0.5)
            {
                spruch = "Immernoch fahrtüchtig.";
            }
            else if (_alkoholPromille <= 1.0)
            {
                spruch = "Schon proper angeheitert.";
            }
            else if (_alkoholPromille <= 2.5)
            {
                spruch = "Schon mächtig einen in der Krone.";
            }
            else if (_alkoholPromille <= 4)
            {
                spruch = "Schon sehr gefährlich.";
            }
            else
            {
                spruch = "Ooops, das kann nicht überlebt werden.";
            }
            return spruch;
        }

    }
}
