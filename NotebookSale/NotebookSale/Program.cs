using System;

namespace NotebookSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notebook sayini daxil edin:");
            string notebookCountStr = Console.ReadLine();
            int nottebookCount = Convert.ToInt32(notebookCountStr);

            Notebook[] notebooks = new Notebook[nottebookCount];


            for (int i = 0; i < nottebookCount; i++)
            {
                string brand = GetInputStr($"{i + 1}. notebookun brandini daxil edin:", 3, 30);
                string model = GetInputStr($"{i + 1}. notebookun modelini daxil edin:", 3, 30);
                int count = GetInputInt($"{i + 1}. notebookun sayini daxil edin:", 0);
                int ram = GetInputInt($"{i + 1}. notebookun RAM-ni daxil edin:", 2, 128);
                int storage = GetInputInt($"{i + 1}. notebookun yaddasini daxil edin:", 0);
                double price = GetInputDouble($"{i + 1}. notebookun qiymetini daxil edin:", 0);

                notebooks[i] = new Notebook(model, count, price)
                {
                    Brand = brand,
                    Storage = storage,
                    RAM = ram
                };

            }

            Console.WriteLine("\n================Notebooks===================\n");
            foreach (var item in notebooks)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        static string GetInputStr(string inputName, int min = 0, int max = int.MaxValue)
        {
            string input;
            do
            {
                Console.WriteLine(inputName);
                input = Console.ReadLine();

            } while (input == null || input.Length < min || input.Length > max);

            return input;
        }

        static int GetInputInt(string inputName, int min = int.MinValue, int max = int.MaxValue)
        {
            string inputStr;
            int input;
            do
            {
                Console.WriteLine(inputName);
                inputStr = Console.ReadLine();
                input = Convert.ToInt32(inputStr);

            } while (input < min || input > max);

            return input;
        }

        static double GetInputDouble(string inputName, double min = double.MinValue, double max = double.MaxValue)
        {
            string inputStr;
            double input;
            do
            {
                Console.WriteLine(inputName);
                inputStr = Console.ReadLine();
                input = Convert.ToDouble(inputStr);

            } while (input < min || input > max);

            return input;
        }
    }
}
