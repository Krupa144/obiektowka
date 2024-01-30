using System.Globalization;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Data kalendarz = new (currentDateTime.Year, currentDateTime.Month, currentDateTime.Day);

            Console.WriteLine("Bieżąca data: " + kalendarz.GetData1());

            kalendarz.przód();
            Console.WriteLine("Data po przesunięciu o tydzień w przód: " + kalendarz.GetData1());

            kalendarz.tył();
            Console.WriteLine("Data po przesunięciu o tydzien" + kalendarz.GetData1());
        }
    }
}