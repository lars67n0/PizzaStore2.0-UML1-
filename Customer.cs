using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2._0_UML1_
{
    class Customer
    {
        // instance Fields

        private string _firstName;
        private string _lastName;
        private string _adress;
        private int _phoneNumber;

        //Constructor
        public Customer(string firstName, string lastName, string adress, int phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _phoneNumber = phoneNumber;
        }

        //Properties

        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        public string Adress { get { return _adress; } }
        public int PhoneNumber { get { return _phoneNumber; } }
        //methods
        //public void CustomerInfo()
        //{
        //    // Costumer Information
        //    Console.Write("What Is Your Full Name?  = ");
        //    string firstname = Console.ReadLine();



        //    Console.Write("What is Your Adress?  = ");
        //    string adress = Console.ReadLine();


        //    Console.Write("What is Your Phone?  = ");
        //    string phoneNumber = Console.ReadLine();
        //    Console.WriteLine();
        //    Console.WriteLine();


        //    Console.WriteLine("Your Order Will Be Delivered To : ");
        //    Console.WriteLine();
        //    Console.WriteLine("Name : " + firstname);
        //    Console.WriteLine();
        //    Console.WriteLine("Your Adress is : " + adress);
        //    Console.WriteLine();
        //    Console.WriteLine("Your Phone Number Is : " + phoneNumber);
        //}
        //    // End Costumer Informatio

        public override string ToString()
        {
            return "Name Of Customer " + this.FirstName +" "+ this.LastName + " Food Will Be Delivered To " + this.Adress + " Customer can be reached on " + this.PhoneNumber;
        }

    }
}
