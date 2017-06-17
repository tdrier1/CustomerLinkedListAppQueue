using System;

namespace CustomerLinkedListApp
{
    class Customer
    {
        private int number;
        private string company;
        private string contact;
        private string city;
        private string state;
        private double totalpurch;
        private string purchdate;

        public int Number
        {
                get{return number;}
                set{number = value;}
        }
        public string Company
        {
                get {return company;}
                set{company = value;}   
        }

        public string Contact
       {
                get {return contact;}
                set{contact = value;}   
        }

        public string City
        {
                get {return city;}
                set{city = value;}   
        }

        public string State
        {
                get {return state;}
                set{state = value;}   
        }

        public double TotalPurch
        {
                get {return totalpurch;}
                set{totalpurch = value;}   
        }

        public string PurchDate
        {
                get {return purchdate;}
                set{purchdate = value;}   
        }
    }
    
}