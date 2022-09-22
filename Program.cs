namespace Mathe Quiz
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

                pTextLine(ConsoleColor.Green, "Correct...but can you get anouther one???");
            }
            else pTextLine(ConsoleColor.Magenta, $"Wrong! The correct answer was: {result}");
            

            pTextLine(ConsoleColor.Cyan, "Wanna Play Again [y/n]?");

            string input = Console.ReadKey().KeyChar.ToString();

            Console.WriteLine();

            if (input == "y")
            {
                Main(args);
            }
            else if (input == "n")
            {
                pTextLine(ConsoleColor.Red, "I knew you´re bad");
                
            }
            else if (input != "n")
            {
                
                pTextLine(ConsoleColor.Magenta, "Bro just put n or y..... its easy");
 
                string input2 = Console.ReadKey().KeyChar.ToString();

                if (input2 == "y")
                {
                    Main(args);
                }
                else if (input2 == "n")
                {
                    Console.WriteLine();

                    pTextLine(ConsoleColor.Red, "I knew you´re bad");

                }
                else if (input2 != "n")
                {
                    Console.WriteLine();
                    pTextLine(ConsoleColor.DarkRed, "Go away no more playing.");
                   

                }
                }

            }
          
        }
    }
