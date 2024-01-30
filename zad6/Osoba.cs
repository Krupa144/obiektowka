using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Osoba
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int wiek {  get; set; }
         


       

        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }
        public void Wypisz()
        {
            Console.WriteLine(imie, nazwisko, wiek );
        }


    }
}
