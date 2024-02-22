using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        public class Customer
        {
            public string Name;
            public string City;
        }

        private static List<Customer> GetCustomers()
        {
            Customer c1 = new Customer { Name="Tom", City="Dublin"};
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            return customers;
        }
        static void Main(string[] args)
        {
            List<Customer> customers = GetCustomers();

            var query1a = from customer in customers
                          where customer.City == "Dublin" || customer.City == "Galway"
                          orderby customer.Name
                          select customer.Name;

            var query1b = customers
                          .Where(c => c.City == "Dublin" || c.City == "Galway")
                          .OrderBy(c => c.Name)
                          .Select(c => c.Name);

            foreach (var item in query1b)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
