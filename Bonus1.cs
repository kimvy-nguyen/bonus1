using System;

namespace Bonus1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!");
            bool cont = true;
            while (cont)
            {
                Console.Write("\nEnter a numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());

if (grade >= 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (87 >= grade && grade >= 80)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (79 >= grade && grade >= 67)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (66 >= grade && grade >= 60)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else
                {
                    Console.WriteLine("Letter Grade: F");
                }

                Console.Write("\nContinue?(y/n):");
                string option = Console.ReadLine();

                if (option == "Y" || option == "y")
                {
                    cont = true;
                }
                else if (option == "N" || option == "n")
                {
                    cont = false;
                }

            }

                Console.WriteLine("\nGoodbye.");
            }
                
             
        
    }
}
