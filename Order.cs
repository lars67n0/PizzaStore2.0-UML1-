using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2._0_UML1_
{
    class Order
    {
        //Instance Fields
        private double _tax;
        private int _delivery;
        public int _p1Price;
        public int _p2Price;
        public int _p3Price;
        public double _totalprice;
        //Constructor
        public Order(int deliveryPrice)
        {
            _tax = 0.2;
            _delivery = deliveryPrice;
            _p1Price = 110;
            _p2Price = 120;
            _p3Price = 90;
            _totalprice = 0;
            
        }

        //Properties
        public int DeliveryPrice { get { return _delivery; } }

        public override string ToString()
        {
            return "Delivery Cost = " + this.DeliveryPrice;
        }


        //method

        public void OrderInformation()
        {
            // Pizza Order
            Console.WriteLine("Write The Name Of the Pizza u Wish To buy ");
            string Pizzanr = Console.ReadLine();

            Console.WriteLine("is This Your Order");
            Console.WriteLine();
            Console.WriteLine("Order: " + Pizzanr);
            if (Pizzanr == "Marg")
            {
                Console.WriteLine();
                _totalprice = (_p1Price * (1 + _tax)) + _delivery;
                Console.WriteLine("Marg Cost : " + _p1Price + " kr,- " + " + Delivery Cost : " + _delivery + " kr,- ");
                Console.WriteLine("Tax Included");
                Console.WriteLine("Total Cost Of Order " + _totalprice + " kr,-");


            }
            else if (Pizzanr == "Morg")
            {
                Console.WriteLine();
                _totalprice = (_p2Price * (1 + _tax)) + _delivery;
                Console.WriteLine("Morg Cost : " + _p2Price + " kr,- " + " + Delivery Cost : " + _delivery + " kr,- ");
                Console.WriteLine("Tax Included");
                Console.WriteLine("Total Cost Of Order " + _totalprice + " kr,-");

            }
            else if (Pizzanr == "Port")
            {
                Console.WriteLine();
                _totalprice = (_p3Price * (1 + _tax)) + _delivery;
                Console.WriteLine("Morg Cost : " + _p3Price + " kr,- " + " + Delivery Cost : " + _delivery + " kr,- ");
                Console.WriteLine("Tax Included");
                Console.WriteLine("Total Cost Of Order " + _totalprice + " kr,-");
                Console.WriteLine("");
               
            }
            else
            {
                Console.WriteLine("Name Not Accepted!");
            }
            // End Pizza Order
        }
    }
}
