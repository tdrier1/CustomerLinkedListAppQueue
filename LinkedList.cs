using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomerLinkedListApp
{
    class LinkedList
    {
        private Node firstnode;
        private Node lastnode;

        public LinkedList()
        {
            firstnode = null;
            lastnode = null;
        }
        public int CreateLinkedList()
        {
            int i = 0;

            var db = File.ReadAllLines("customerdb.txt");
              
            foreach(string line in db )
            {
            Customer custobj = new Customer();

            char[] delim = new char[] { ',' };
            string[] splits = line.Split(delim);

            custobj.Number = Convert.ToInt32(splits[0]);
            custobj.Company = splits[1];
            custobj.Contact = splits[2];
            custobj.City = splits[3];
            custobj.State = splits[4];
            custobj.PurchDate = splits[5];
            custobj.TotalPurch = Convert.ToDouble(splits[6]);
                    
            AddToEndList(custobj);
            i++;
            }
            return i;        
        }
        public void AddToEndList(Customer data)
        {
            Node newnode = new Node(data);

            if(firstnode == null)
            
                firstnode = newnode;
            else
                lastnode.handle = newnode;
                lastnode = newnode;
        }
        public void DisplayList()
        {
            Node n = firstnode;

            while(n != null)
            {
                Console.WriteLine("{0, -10} {1, -10}  {2, -10} {3, -10} {4, -10} {5, -15} {6}", n.info.Number, n.info.Company, n.info.Contact, n.info.City, n.info.State, n.info.PurchDate, n.info.TotalPurch);

                n = n.handle;
            }
        }
        public void WriteList()
        {
            using(var fs = new FileStream("customerdb.txt", FileMode.Truncate, FileAccess.Write))
            using (var sw = new System.IO.StreamWriter(fs))
            {
                Node n = firstnode;

                while(n != null)
                {
                    sw.Write(n.info.Number + ",");
                    sw.Write(n.info.Company + ",");
                    sw.Write(n.info.Contact + ",");
                    sw.Write(n.info.City + ",");
                    sw.Write(n.info.State + ",");
                    sw.Write(n.info.PurchDate + ",");
                    sw.Write(n.info.TotalPurch);
                    sw.Write(Environment.NewLine);

                    n = n.handle;
                }
            }
        }
        public void SearchList(string x)
        {
            int count = 0;
            Node n = firstnode;

            while(n != null)
            {
                if(n.info.Company == x)
                {
                    Console.WriteLine("{0, -10} {1, -10}  {2, -10} {3, -10} {4, -10} {5, -15} {6}", n.info.Number, n.info.Company, n.info.Contact, n.info.City, n.info.State, n.info.PurchDate, n.info.TotalPurch);
                    count++;
                }

                n = n.handle;
            }

            if(count == 0)
                {
                    Console.WriteLine("Company Not Found!");
                }        
        }
        public void NewCust()
        {
                Customer custobj = new Customer();

                Random rdm = new Random();
                int result = rdm.Next(0,1000);

                Console.WriteLine("Please enter a company name: ");
                custobj.Company = Console.ReadLine();

                Console.WriteLine("Please enter a contact name: ");
                custobj.Contact = Console.ReadLine();

                Console.WriteLine("Please enter a city: ");
                custobj.City = Console.ReadLine();

                Console.WriteLine("Please enter a state: ");
                custobj.State = Console.ReadLine();

                custobj.Number = result;
                custobj.TotalPurch = 0;
                custobj.PurchDate = "N/A";

                AddToEndList(custobj);
        }
        public void DeleteStartList()
        {
                Customer custobj = new Customer();

                if(firstnode == null)
                {
                    Console.WriteLine("No customers!");
                    return;
                }
                custobj = firstnode.info;
                firstnode = firstnode.handle;
        }
        public void UpdateCust(int x)
        {
            Console.WriteLine("Please enter a date of purchase:");
            string date = Validation.DateInput();

            Console.WriteLine("Please enter a purchase amount to be added to total:");
            double amount = Validation.DoubleInput();

            Node n = firstnode;

            while(n != null)
            {
                if(n.info.Number == x)
                {
                    n.info.PurchDate = date;
                    n.info.TotalPurch = n.info.TotalPurch + amount;

                    Console.WriteLine("{0, -10} {1, -10}  {2, -10} {3, -10} {4, -10} {5, -15} {6}", n.info.Number, n.info.Company, n.info.Contact, n.info.City, n.info.State, n.info.PurchDate, n.info.TotalPurch);
                }
                n = n.handle;
            }
        }
    }
}