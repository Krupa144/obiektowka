namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Licz liczba1 = new Licz(2);
            Licz liczba2 = new Licz(5);

            liczba1.Dodaj(5);
            liczba1.Stan();
        }
    }
}