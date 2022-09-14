using System;

namespace SuitsAndValues
{
    class Program
    {
        private static readonly Random random = new Random();
        static void Main(string[] args)
        {
            int numberBetween0And3 = random.Next(4);
            int numberBetween0And13 = random.Next(1, 14);

            Card myCard = new Card((Values)numberBetween0And13, (Suits)numberBetween0And3);
            Console.WriteLine(myCard.Name);
        }
    }
}