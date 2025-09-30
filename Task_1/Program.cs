using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isParsed;
            string input;
            do
            {

                Console.WriteLine("enter their favorite food");

                input = Console.ReadLine();
                isParsed = Enum.TryParse<Food>(input, out Food food);

                if (isParsed)
                {
                    Console.WriteLine($"You chose: {food}");
                }
                else
                {
                    Console.WriteLine("That food is not on the menu!");
                }
            }while (!isParsed);
        }

    }
}