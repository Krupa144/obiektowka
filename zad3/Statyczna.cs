using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Statyczna
    {
        public int I;
        public static int Liczba;

        static public int Zwieksz()
        {
            return Liczba++;
        }

        public Statyczna(int i)
        {
            I = i;
            Zwieksz();
        }

    }
}
