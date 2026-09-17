using System;
using System.Collections.Generic;
using System.Text;

namespace KavezogepApp
{
    internal class Kavezogep
    {
        private int vizKeszletMl;

        public void VizTolt(int ml)
        {
            if (ml < 0)
            {
                Console.WriteLine("Negatív értéket szeretnél megadni!");
            }
            else
            {
                vizKeszletMl += ml;
                Console.WriteLine($"Víz sikeresen betöltve, Érték: {ml} ml");
            }
        }

        public void KaveFozes()
        {
            if (vizKeszletMl >= 150)
            {
                vizKeszletMl -= 150;
                Console.WriteLine($"Sikeres kávéfőzés!, A vízszint csökkent 150 ml-el, maradék vízszint: {vizKeszletMl} ml");
            }
            else
            {
                Console.WriteLine("Nincsen elég víz a kávéfőző gépben!");
            }
        }

    }
}
