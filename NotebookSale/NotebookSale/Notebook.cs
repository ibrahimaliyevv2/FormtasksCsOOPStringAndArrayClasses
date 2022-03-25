using System;
namespace NotebookSale
{
    public class Notebook:Product
    {
        public Notebook(string model, int count, double price) : base(count, price)
        {
            this.Model = model;
        }

        public string Brand;
        public string Model;
        public int RAM;
        public int Storage;

        public string GetInfo()
        {
            return $"Brand: {this.Brand} - Model: {this.Model} - Price: {this.Price} - RAM: {this.RAM} - Storage: {this.Storage}";
        }
    }
}
