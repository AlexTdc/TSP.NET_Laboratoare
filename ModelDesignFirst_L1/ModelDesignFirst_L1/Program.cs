using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void TestOneToMany()
        {
            Console.WriteLine("One to many association");
            using (Model1Container context = new Model1Container())
            {
                Customer c;
                Order o;
                string name, city, totalValue, date, exit = "n";
                while (exit == "y")
                {
                    Console.Write("Enter customer details:\nEnter name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter city: ");
                    city = Console.ReadLine();
                    Console.Write("Enter order details:\nEnter total value: ");
                    totalValue = Console.ReadLine();

                    date = DateTime.Now.ToString();

                    c = new Customer()
                    {
                        Name = name,
                        City = city
                    };
                    o = new Order()
                    {
                        TotalValue = totalValue,
                        Date = date,
                        Customer = c
                    };

                    context.SaveChanges();

                    Console.WriteLine("Doriti sa mai adaugati?(y/n\n");
                    exit = Console.ReadLine();

                }

                var items = context.CustomerSet;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Order)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }



            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Test Model Designer First");
            TestPerson();
            TestOneToMany();
            Console.ReadKey();

        }

        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                Person p;
                /*Person p = new Person()
                {
                    FirstName = "Julie",
                    LastName = "Andrew",
                    MiddleName = "T",
                    TelephonNumber = "1234567890"
                };
                context.People.Add(p);
                context.SaveChanges();*/
                var items = context.People;
                string val;
                string fn, ln, mn, tn;
                string end = "n";

                val = Console.ReadLine();
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
                while (end == "n")
                {

                    Console.Write("Enter first name: ");
                    fn = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    ln = Console.ReadLine();
                    Console.Write("Enter middle name: ");
                    mn = Console.ReadLine();
                    Console.Write("Enter telephone number: ");
                    tn = Console.ReadLine();

                    p = new Person()
                    {
                        FirstName = fn,
                        LastName = ln,
                        MidleName = mn,
                        TelephonNumber = tn
                    };
                    context.People.Add(p);
                    context.SaveChanges();
                    Console.Write("End? y/n");
                    end = Console.ReadLine();

                }
            }

        }

    }
}