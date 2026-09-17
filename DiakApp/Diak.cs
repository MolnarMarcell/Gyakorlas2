using System;
using System.Collections.Generic;
using System.Text;

namespace DiakApp
{
    internal class Diak
    {

        public string Nev { get; set; }
        public double Atlag { get; set; }

        public Diak(string nev, double atlag)
        {
            this.Nev = nev;
            this.Atlag = atlag;
        }
    }
}
