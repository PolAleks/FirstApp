namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Valera";
            Console.WriteLine(MyName);
            Console.WriteLine("\tПривет, мир\n\tМне 27 лет\n\tMy name is {0}",MyName);
            Console.WriteLine("\u0023");
            Console.ReadKey();
        }
    }
}