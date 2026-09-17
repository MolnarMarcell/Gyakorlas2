using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonApp
{
    internal class Okostelefon
    {
        public string Modell { get; set; }

        private int toltottseg;

        public int Toltottseg
        {
            get { return toltottseg; }
            set
            {
                if ( value <0)
                {
                    toltottseg = 0;
                }
                else if (value >100)
                {
                    toltottseg = 100;
                }
            }
        }

    }
}
