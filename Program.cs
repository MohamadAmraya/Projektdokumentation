using System.Runtime.CompilerServices;

namespace Mathe_Quiz
{
    internal class Program
    {
        static void pTextLine(ConsoleColor col, string text)
        {
            Console.ForegroundColor = col;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int Plu1, Plu2;

            Random rand = new Random();
            Plu1 = rand.Next(5, 50);
            Plu2 = rand.Next(5, 50);

            Console.Write($"{Plu1} + {Plu2} = ");

            string result = (Plu1 + Plu2).ToString();

            if (Console.ReadLine() == result)
            {

                Console.WriteLine("Correct...but can you get anouther one???");
            }
            else Console.WriteLine($"Wrong! The correct answer was: {result}");

            bool yPressed = false;

            Console.WriteLine("Wanna Play Again [y/n]?");
            while (!yPressed)
            {
                
                

                    string input = Console.ReadKey().KeyChar.ToString();

                    yPressed = input == "y";


                Console.WriteLine();
                    if (input == "n")
                    {
                        pTextLine(ConsoleColor.Red, "I knew you´re bad");
                        break;
                  
                }

            }

            if (yPressed)
                Main(args);

            while (true) { }
        }
    }
}
