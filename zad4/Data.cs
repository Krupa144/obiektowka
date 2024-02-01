using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Data
    {

        private int rok;
        private int mieisac;
        private int dzien;

        public Data(int rok, int miesiac, int dzien)
        {
            this.rok = rok;
            this.mieisac = miesiac;
            this.dzien = dzien;

        }

        public void Dzis()
        {
            Console.WriteLine($"{dzien}, {mieisac}, {rok}");
        }

        public void Przód()
        {
            dzien += 7;

            int y = 0;

            switch (mieisac)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    y = 31;
                    break;
                case 2:
                    if (rok % 4 == 0)
                    {
                        y = 29;
                    }
                    else
                    {
                        y = 28;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    y = 30;
                    break;
            }

            if (dzien > y)
            {
                dzien -= y;
                mieisac += 1;
            }

            if (mieisac > 12)
            {
                mieisac -= 12;
                rok += 1;
            }

        }

        public void Tył()
        {
            {
                dzien -= 7;

                int x = 0;

                switch (mieisac)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (rok % 4 == 0)
                        {
                            x = 29;
                        }
                        x = 28;
                        break;
                    case 2:
                        if (rok % 4 == 0)
                        {
                            x = 29;
                        }
                        else
                        {
                            x = 28;
                        }

                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        x = 30;
                        break;
                }

                if (dzien < 1)
                {
                    mieisac -= 1;
                    if (mieisac < 1)
                    {
                        mieisac = 12;
                        rok -= 1;
                    }

                    dzien += x;
                }


            }
        }
    }
}


