namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.Write("What your favorit day of week? ");
            DayOfWeek day = (DayOfWeek)byte.Parse(Console.ReadLine());
            Console.WriteLine("Your favorit day is {0}", day);
        }
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
    }
}