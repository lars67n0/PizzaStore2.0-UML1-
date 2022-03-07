using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2._0_UML1_
{
    class Pizza
    {
        //instance fields
        private string _name;
        private int _price;

        //Constructor
        public Pizza(string name, int price) { _name = name; _price = price; }
        

        //properties
        

        public string Name { get { return _name; } }

        public int Price { get { return _price; } }

        //method

        public override string ToString()
        {
            return "Name Of Pizza " + this.Name +" The Price Of " + this.Name + " Is : "+ this.Price;
        }







    }
}
