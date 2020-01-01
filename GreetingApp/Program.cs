using System;

namespace GreetingApp
{
    class Program
    {
        private const string nameQ = "What is your name?";
        private const string ageQ = "What is your age?";
        private const string placeQ = "What are you from?";

        static void Main(string[] args)
        {
            Console.WriteLine(nameQ);
            string name = Console.ReadLine();

            Console.WriteLine(ageQ);
            string age = Console.ReadLine();

            Console.WriteLine(placeQ);
            string place = Console.ReadLine();

            Console.WriteLine("Hello, "+name+"!  You are "+age+", "+"from "+place+"!");
        }
    }
}
