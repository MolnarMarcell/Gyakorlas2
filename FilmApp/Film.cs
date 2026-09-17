using System;
using System.Collections.Generic;
using System.Text;

namespace FilmApp
{
    internal class Film
    {
        public string Cim;
        public int HosszPercben;

        public Film(string cim, int hosszpercben)
        {
            this.Cim = cim;
            this.HosszPercben = hosszpercben;
        }
    }
}
