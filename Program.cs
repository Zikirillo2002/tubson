using System;
using System.Numerics;

namespace tubson

{

    internal class Program
    {

        static void Main(string[] args)
        {
            double number, boluvchilarsoni = 0;
            bool isnumber1;
            Console.Write(" sonni kiriting --> ");
            isnumber1 = double.TryParse(Console.ReadLine(), out number);
            Console.WriteLine();
            while (!isnumber1)
            {
                Console.WriteLine("Siz noto'g'ri son kiritdingiz !!! ");
                Console.WriteLine("Tekshirib boshqa son kiriting !!! ");
                Console.WriteLine();
                Console.Write("sonni kiriting --> ");
                isnumber1 = double.TryParse(Console.ReadLine(), out number);
                Console.WriteLine();
            }
            if (number == 1 || number == 0)
            {
                Console.WriteLine($" {son1} soni tub ham murakkab son ham emas !!! ");
                Console.WriteLine();
                Main(args);
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        boluvchilarsoni++;
                    }
                    if (boluvchilarsoni > 2)
                    {
                        Console.WriteLine($" {number} soni murakkab  son  ");
                        Console.WriteLine();
                        Main(args);
                    }

                }
            }
            Console.WriteLine($" {number} soni tub  son  ");
            Console.WriteLine();
            Console.WriteLine();
            Main(args);

        }

    }

}


