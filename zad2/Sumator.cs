namespace zad2
{
    internal class Sumator
    {
        private int[] Liczby;

        public int Suma()
        {
            int suma = 0;
            foreach (int i in Liczby)
            {
                suma += i;
            }
            return suma;
           
        }

        public int Sumapodziel3() 
        {
            int suma3 = 0;
            foreach (int i in Liczby)
            {
                if (i % 3 == 0)
                {
                   suma3 += i;
                }
            }
            return suma3;
            
        }

        public Sumator(int[] liczby)
        {
            Liczby = liczby;
        }

        public int ileElementow()
        {
            int ile = 0;
            foreach (int i in Liczby)
            {
                ile++;
            }
            return ile;
        }

        public void WszystkieElementy()
        {
            foreach(int i in Liczby)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public void WypiszElementy(int lowIndex,  int highIndex)
        {
            for (int i = lowIndex; i<= highIndex; i++)
            {
                if (i >= 0 && i< ileElementow())
                {
                    Console.Write(Liczby[i]);
                }
                
            }
            Console.WriteLine();
        }

    }
}
