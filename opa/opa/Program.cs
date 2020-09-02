using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opa;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userlist = new List<User>();

            User user1 = new User("Aragorn", 34, "Rivendell");
            User user2 = new User("Legolas", 29, "Mirkwood");
            User user3 = new User("Gimli", 31, "Helms Deep");
            User user4 = new User("Boromir", 33, "Gondor");
            User user5 = new User("Gandalf", 69, "Lonely Mountain");

            userlist.Add(user1);
            userlist.Add(user2);
            userlist.Add(user3);
            userlist.Add(user4);
            userlist.Add(user5);

            List<Order> orderlist = new List<Order>();

            for (int i = 0; i < 13; i++)
            {
                string name = Console.ReadLine();
                DateTime orderdate = Convert.ToDateTime(Console.ReadLine());
                int quantity = Convert.ToInt32(Console.ReadLine());
                int price = Convert.ToInt32(Console.ReadLine());
                string address = Console.ReadLine();
                Order order = new Order(name, orderdate, quantity, price, address);
                orderlist.Add(order);
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {

            }
            var topfive =new List<Order>();
            var hold = new List<Order>();
            hold = orderlist;
            int highprice=0;
            if (choice == 2)
            {
                var index = 0;
                for (int j=0;j <= 5;j++)
                {
                    orderlist[0].Price = highprice;
                    for (int i = 0; i < hold.Count; i++)
                    {
                        if (hold[i].Price >= highprice)W
                        {
                            highprice = hold[i].Price;
                            index = i;
                        }
                    }

                    hold.RemoveAt(index);

                    
                }
            }

            // Click the "..." next to "using System" statement to view the code            
            // Write your code below to performing the 3 operations
            // 1. Take in new Orders
            // 2. Display the 5 most expensive
            // 3. Display all orders made by users to a different address


        }
    }

    // Create class User as specified. Create constructor and use public properties.

    class User
    {
        private string name;
        private int age;
        private string address;
        public string Name
        {
            get => name;
            set => name = value;

        }
        public int Age
        {
            get => age;
            set => age = value;

        }
        public string Address
        {
            get => address;
            set => address = value;

        }

        public User(string namepass, int agepass, string addresspass)
        {
            this.Name = namepass;
            this.Address = addresspass;
            this.Age = agepass;
        }
    }

    // Create class Order as specified. Create constructor and use public properties.

    class Order
    {
        private string name;
        private DateTime orderdate;
        private int quantity;
        private int price;
        private string address;

        public string Name
        {
            get => name;
            set => name = value;

        }
        public string Address
        {
            get => address;
            set => address = value;

        }
        public int Price
        {
            get => price;
            set => price = value;

        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;

        }
        public DateTime Orderdate
        {
            get => orderdate;
            set => orderdate = value;

        }

        public Order(string namepass, DateTime orderdate,int quantitypass, int pricepass, string addresspass)
        {
            if (quantitypass > 0)
            {
                this.Quantity = quantitypass;
            }
            else
            {
                Console.WriteLine("There should be atleast 1 item");
                return;
            }
            if (pricepass > 0)
            {
                this.Price = pricepass;
            }
            else
            {
                Console.WriteLine("Price iS invalid");
                return;
            }

            this.Name = name;
            this.Orderdate = orderdate;
            this.Address = addresspass;

            Console.WriteLine("New order has been placed successfully");
        }
    }

}