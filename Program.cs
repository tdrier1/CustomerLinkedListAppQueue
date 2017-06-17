using System;

namespace CustomerLinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            do
            {
            LinkedList customerlist = new LinkedList();

            int i = customerlist.CreateLinkedList();

            Console.WriteLine("Customer Mgmt System w/ Stack Implementation");
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1: View Customer List in Order Added");
            Console.WriteLine("2: Search By Company Name");
            Console.WriteLine("3: Add A Customer to List");
            Console.WriteLine("4: Delete Newest Customer from List");
            Console.WriteLine("5: Update A Customer Sales Record");
            Console.WriteLine("6: Count of Current Records");
            Console.WriteLine("7: Exit");
            Console.WriteLine("++++++++++++++++++++++++++");
            int choice = Validation.MenuInput();

            switch(choice)
            {
                case 1:
                {   Console.WriteLine("Here is our customer list:");
                    Console.WriteLine("++++++++++++++++++++++++++++");
                    Console.WriteLine("Cust No.    Company     Contact     City    State    Last Purch Date.  Total Sales($)");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    customerlist.DisplayList();
                    run = Validation.Cont();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Please enter a company name: ");
                    string x = Console.ReadLine();
                    Console.WriteLine("Cust No.    Company     Contact     City    State    Last Purch Date.  Total Sales($)");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    customerlist.SearchList(x);
                    run = Validation.Cont();
                    break;
                }
                case 3:
                {
                    customerlist.NewCust();
                    customerlist.WriteList();
                    run = Validation.Cont();
                    break;
                }
                case 4:
                {
                    customerlist.PopCust();
                    Console.WriteLine("Cust No.    Company     Contact     City    State    Last Purch Date.  Total Sales($)");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    customerlist.DisplayList();
                    customerlist.WriteList();
                    run = Validation.Cont();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Please enter a customer number to update: \n");         
                    customerlist.DisplayList();
                    int x = Convert.ToInt32(Console.ReadLine());
                    customerlist.UpdateCust(x);
                    Console.WriteLine("Cust No.    Company     Contact     City    State    Last Purch Date.  Total Sales($)");
                    Console.WriteLine("-------------------------------------------------------------------------------------");
                    customerlist.DisplayList();
                    customerlist.WriteList();
                    run = Validation.Cont();
                    break;
                }
                case 6:
                {
                    Console.WriteLine($"Count of Current Records: {i}");
                    break;
                }
                case 7:
                {
                    run = false;
                    break;
                }
            }
        }while(run == true);
        }
    }
}
