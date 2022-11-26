namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Александр";
            byte Age = 40;
            bool HaveIPet = true;
            double ShoeSize = 26.5;
            Console.WriteLine("Меня зовут {0}",MyName);
            Console.WriteLine("Мне {0}", Age);
            Console.WriteLine("У тебя есть питомец? {0}", HaveIPet);
            Console.WriteLine("Размер вашей стопы: {0}", ShoeSize);
            Console.ReadKey();
        }
    }
}