using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_320_4207_Linienzeichner
{
    internal class Linienzeichner
    {
        private char _symbol = '*';


        public Linienzeichner()
        {

        }
        public Linienzeichner(char symbol)
        {
            
            _symbol = symbol;
        }

        public string Zeichne(int anzahl)
        {
            return new string(_symbol, anzahl);
        }


        // 1. Überladung
        public string Zeichne(int anzahl, char symbol)
        {
            return new string(symbol, anzahl);
        }

        // 2. Überladung
        public string Zeichne(float prozent, int total)
        {
            return new string(_symbol, Convert.ToInt32(Math.Round(total * prozent)));

        }

        // 3. Überladung
        public string Zeichne(float prozent, int total, char symbol)
        {
            return new string(symbol, Convert.ToInt32(Math.Round(total * prozent)));
        }

    }
}
