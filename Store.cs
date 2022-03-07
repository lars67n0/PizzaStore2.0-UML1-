using System;

namespace PizzaStore2._0_UML1_
{
    class Store
    {
        static void Main(string[] args)
        {
            Pizza p1 = new Pizza("Marg", 110);
            Pizza p2 = new Pizza("Morg", 120);
            Pizza p3 = new Pizza("Port", 90);

            Customer c1 = new Customer("Ole", "Hansen", "Olehansenvej 22B,s", 89208920);
            Customer c2 = new Customer("Hans", "Ole", "HansoleVej 2a", 80102090);
            Customer c3 = new Customer("elo", "snah", "elosnahVej 5", 90402010);

            Order o1 = new Order(40);
            Order o2 = new Order(40);
            Order o3 = new Order(40);

            Console.WriteLine(p1.ToString());
            Console.WriteLine();
            Console.WriteLine(p2.ToString());
            Console.WriteLine();
            Console.WriteLine(p3.ToString());
            Console.WriteLine(o1.ToString());

            Console.WriteLine();
            o1.OrderInformation();
            


            Console.WriteLine(c3.ToString());
        }
    }
}
