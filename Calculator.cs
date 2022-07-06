using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number_One = 0;
            int Number_To = 0;
            string Badge = "";
            string Badges = "+ - * /";
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" God Developers");
            Console.ResetColor();
            Console.WriteLine();
            try
            {
                Console.Write(" Enter Number One : ");
                Number_One = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write(" Enter Number To : ");
                Number_To = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write($" Select The Badge[{Badges}] : ");
                Badge = Console.ReadLine();
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Not Suppurt Format...");
                Console.ResetColor();
            }
            switch (Badge)
            {
                case "+":
                    {
                        Console.WriteLine(" Answer Is : " + (Number_One + Number_To));
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(" Answer Is : " + (Number_One - Number_To));
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(" Answer Is : " + (Number_One * Number_To));
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine(" Answer Is : " + (Number_One / Number_To));
                        break;
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" Can't Fount Badge...");
                        Console.ResetColor();
                        break;
                    }
            }
            Console.ReadKey();

        }
    }
}

