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

        private DateTime kalendarz;
        public Data(int year, int month, int day) 
        {
            kalendarz = new DateTime(year, month, day);

        }

        public string GetData1()
        {
            return kalendarz.ToString();
        }

        public void przód()
        {
            kalendarz = kalendarz.AddDays(7);   
        }

        public void tył()
        {
            kalendarz = kalendarz.AddDays(-7);
        }

        
    }
}
