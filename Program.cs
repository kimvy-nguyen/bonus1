using System;

namespace Lab2KNCNET0719
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            bool cont = true;
        while (cont)
            {
        
           // Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.Write("Enter Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Width: ");
            double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;
        Console.WriteLine("Area: {0}", area);

            double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter: {0}", perimeter);

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

    
            
        
    
//}
