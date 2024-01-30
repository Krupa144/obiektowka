using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Czytelnik : Osoba
    {
        public List<Ksiazka> PrzeczytaneKsiazki { get; set; }

        public Czytelnik(string imie, string nazwisko, int wiek) : base(imie, nazwisko, wiek)
        {
            PrzeczytaneKsiazki = new List<Ksiazka>();
        }

        public void DodajPrzeczytanaKsiazke(Ksiazka ksiazka)
        {
            PrzeczytaneKsiazki.Add(ksiazka);
        }
    }
}
