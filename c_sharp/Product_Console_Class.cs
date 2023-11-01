using System;

namespace Product_Console_Class
{
    class Product
    {
        string ProductName;
        int ProductPrize;
        int ProductQuantity;

        public void getdata(string ProductName,int ProductQuantity,int ProductPrize)
        {
            this.ProductName = ProductName;
            this.ProductQuantity = ProductQuantity;
            this.ProductPrize = ProductPrize;
        }

        public void displaydata()
        {
            Console.WriteLine("--------------------------------------");
            Console.Write("Product Name: " + ProductName + "\n");
            Console.Write("Product Quantity: " + ProductQuantity + "\n");
            Console.Write("Product Prize: " + ProductPrize + "\n");    
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            string name;
            int quantity;
            int prize;
            int stock = 30;

            Console.Write("Enter Product Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Prize: ");
            prize= Convert.ToInt32(Console.ReadLine());

            if(quantity>0 && quantity<stock)
            {
                int remainigprize = stock - quantity;
                int totalamount = prize * quantity;
                pro.getdata(name, quantity, prize);
                pro.displaydata();
                Console.WriteLine();
                Console.WriteLine("Remaining Stock: " + remainigprize);
                Console.WriteLine("Total Amount: " + totalamount);
            }
            else
            {
                Console.WriteLine("Insufficient Stock");
            }
            
            Console.ReadKey();
        }
    }
}
