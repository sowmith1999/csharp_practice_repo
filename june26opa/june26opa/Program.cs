using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string productName = Console.ReadLine();
                string category = Console.ReadLine();
                if (category == "Goods")
                {
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    float unitPrice = Convert.ToInt32(Console.ReadLine());
                    int id = manager.AddProduct(productName, category, unitPrice, quantity);
                }
                else
                {
                    float unitPrice = Convert.ToInt32(Console.ReadLine());
                    int id = manager.AddProduct(productName, category, unitPrice);
                }
            }

            int choice = Convert.ToInt32(Console.ReadLine());

            // Enter code for handling 4 operations
            //if(choice)

        }
    }

    // Create class Product as per given specification
    #region solution2
    class ProductManager
    {
        List<Product> products = new List<Product>();

        public int AddProduct(string productName, string category, float unitPrice)
        {
            var prod1=new Product(productName, category, unitPrice);
            return prod1.ProductId;
        }
        public int AddProduct(string productName, string category, float unitPrice,int quantity)
        {
            var prod1 = new Product(productName, category, unitPrice,quantity);
            return prod1.ProductId;
        }

        public int UpdateProduct()
        {

            return 0;
        }

        public int ViewProducts()
        {
            return 0;
        }

        public int Statistics()
        {
            return 0;
        }
    }

    class Product
    {
        private int productId;
        private string productName;
        private string category;
        private int quantity;
        private float unitPrice;
        private float tax;
        private float totalPrice;


        public string Category
        {
            get => category;
            set => category = value;

        }
        public string ProductNmae
        {
            get => productName;
            set => productName = value;

        }
        public string ProductName
        {
            get => productName;
            set => productName = value;

        }
        public int ProductId
        {
            get => productId;
            set => productId = value;

        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;

        }
        public float UnitPrice
        {
            get => unitPrice;
            set => unitPrice = value;

        }
        public float Tax
        {
            get => tax;
            set => tax = value;

        }
        public float TotalPrice
        {
            get => totalPrice;
            set => totalPrice = value;

        }

        public Product(string prodname, string cat, float unitp,int quant)
        {
            Random x = new Random();

            this.ProductId = x.Next(1, 10000);
            this.ProductName = prodname;
            this.Category = cat;
            this.Quantity = quant;
        }
        public Product(string prodname, string cat, float unitp)
        {
            Random x = new Random();
            this.ProductId = x.Next(1, 10000);
            this.ProductName = prodname;
            this.Category = cat;
        }
    }


    #endregion

    // Create class ProductManager as per given specification.
    // Write methods that will perform operations handled in solution1.
    #region solution3



    #endregion

    // Other miscellaneous code, if required
    #region miscellaneous



    #endregion

}