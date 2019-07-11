using System;

namespace Deliverable2KNFunRecommendations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string activity;
            
            Console.WriteLine("Hello user, what are you in the mood for?\nHere are your options:\n1) Action\n2) Chill times\n3) Danger\n4) Good food\n");
            activity = Console.ReadLine();

            Console.WriteLine("How many people are you bringing with you?");
            int guests = Convert.ToInt32(Console.ReadLine());

            if (activity == "Action" || activity == "action" || activity == "ACTION")
            {
                Console.Write("Okay if you're in the mood for action, then you should go Stock Car Racing and travel in");
                if (guests == 0)
                {
                    Console.Write(" sneakers.");
                }
                else if (guests > 0 && guests < 5)
                {
                    Console.Write(" a sedan.");
                }
                else if (guests > 5 && guests < 11)
                {
                    Console.Write(" a Volkswagen bus");
                }
                else
                {
                    Console.Write(" an airplane.");
                }

            }
            else if (activity == "Chill times" || activity == "chill times" || activity == "Chill Times" || activity == "CHILL TIMES")
            {
                Console.Write("Okay if you're in the mood for chilling, then you should go Hiking and travel in");
                if (guests == 0)
                {
                    Console.Write(" sneakers.");
                }
                else if (guests > 0 && guests < 5)
                {
                    Console.Write(" a sedan.");
                }
                else if (guests > 5 && guests < 11)
                {
                    Console.Write(" a Volkswagen bus");
                }
                else
                {
                    Console.Write(" an airplane.");
                }
            }
            else if (activity == "Danger" || activity == "danger" || activity == "DANGER")
            {
                Console.Write("Okay if you're in the mood for danger, then you should go Skydiving and travel in");
                if (guests == 0)
                {
                    Console.Write(" sneakers.");
                }
                else if (guests > 0 && guests < 5)
                {
                    Console.Write(" a sedan.");
                }
                else if (guests > 5 && guests < 11)
                {
                    Console.Write(" a Volkswagen bus");
                }
                else
                {
                    Console.Write(" an airplane.");
                }
            }
            else if (activity == "Good food" || activity == "good food" || activity == "GOOD FOOD" || activity == "Good Food")
            {
                Console.Write("Okay if you're in the mood for good food, then you should go to Taco Bell and travel in");
                if (guests == 0)
                {
                    Console.Write(" sneakers.");
                }
                else if (guests > 0 && guests < 5)
                {
                    Console.Write(" a sedan.");
                }
                else if (guests > 5 && guests < 11)
                {
                    Console.Write(" a Volkswagen bus");
                }
                else
                {
                    Console.Write(" an airplane.");
                }
            }
            else
            {
                Console.WriteLine("I'm sorry, I am not programmed to interpret that response.");
            }
            
            Console.WriteLine("\nGoodbye.");

        }
        
    }
}
