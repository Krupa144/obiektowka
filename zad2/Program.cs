namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = { 2, 4, 5, 6, 7, 8 };
            Sumator sumator = new Sumator(liczby);

            sumator.WypiszElementy(-100, 1000);
            sumator.WypiszElementy(0, 3);
            Console.WriteLine(sumator.Suma());
            sumator.WszystkieElementy();
            Console.WriteLine(sumator.Sumapodziel3());
        }   
    }
}