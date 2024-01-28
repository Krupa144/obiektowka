using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Licz
    {
        private int wartosc;


        public void Dodaj(int liczba)
        {
            wartosc += liczba;

        }

        public void Odejmij(int liczba)
        {
            wartosc -= liczba;
        }

        public Licz(int z) 
        {
            wartosc = z;
        }

        public void Stan()
        {
            Console.WriteLine("wartosc obiektu = " + wartosc);
        }
    }
}
