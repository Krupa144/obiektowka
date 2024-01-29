namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statyczna obiekt = new Statyczna(5); 

            Console.WriteLine(obiekt.I);
            Console.WriteLine(Statyczna.Liczba);

            Statyczna.Zwieksz(); 
            Console.WriteLine(Statyczna.Liczba);
        }
    }
}