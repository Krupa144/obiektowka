using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Ksiazka
    {
        public string Tytul { get; set; }
        public Osoba Autor { get; set; }
        public DateTime DataWydania { get; set; }

        public Ksiazka(string tytul, Osoba autor, DateTime dataWydania)
        {
            Tytul = tytul;
            Autor = autor;
            DataWydania = dataWydania;
        }
    }
}
