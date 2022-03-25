using System;
namespace NotebookSale
{
    public class Product
    {
        public Product(int count, double price)
        {
            this.Count = count;
            this.Price = price;
        }

        public int Count;
        public double Price;
    }
}
