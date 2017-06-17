using System;

namespace CustomerLinkedListApp
{
    class Validation
    {
        public static int MenuInput()
        {
            int choice = 0;
            bool run = true;

            do
            {
            Int32.TryParse(Console.ReadLine(), out choice);
            
                    if(choice < 1 || choice > 6)
                    {
                    Console.Write("Please enter a number between 1 and 6: ");
                    }
                    else
                    {
                        run = false;
                    }                
            }while(run == true);

            return choice;
        }
        public static string DateInput()
        {   
            DateTime date;

                while(!DateTime.TryParse(Console.ReadLine(), out date))
                {
                    Console.Write("Please enter a valid date: ");
                }                
            
            string output = date.ToString("MM/dd/yyyy");

            return output;
        }
        public static double DoubleInput()
        {   
            double input;

                while(!Double.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Please enter a valid dollar amount: ");
                }                
            
            return input;
        }
        public static bool Cont()
        {
            bool output = true;
            bool run = true;
            string input = "";

            Console.WriteLine("\nWould you like to continue?");
            
            do
            {
                
            input = Console.ReadLine();

            if(input.ToLower() != "y" && input.ToLower() != "n")
            {
                Console.Write("Please enter 'y' or 'n': ");
            }
            if(input.ToLower() == "n")
            {
                output = false;
                run = false;
            }
            if(input.ToLower() == "y")
            {
                run = false;
            }
            }while(run == true);

            return output;
        }
    }
}