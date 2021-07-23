using System;
using System.Globalization;
using System.IO;
using Files1.Entities;

namespace Files1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: ");
            string sourcePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\sumary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = new StreamWriter(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product.Name + "," + product.total().ToString("F2" , CultureInfo.InvariantCulture));
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
