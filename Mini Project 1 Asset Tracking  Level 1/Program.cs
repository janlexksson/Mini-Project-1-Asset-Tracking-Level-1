using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Project_1_Asset_Tracking__Level_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is first comment
            //This is second comment and some deleted line


            //Console.WriteLine("Asset tracking");
            //List<AllAssets> allAssets = new List<AllAssets>();

            ////List<Computers> computers = new List<Computers>();

            //List<Computers> extraComputer = new List<Computers>
            //{
            //    new Computers("Computer", "HP", "Elitebook", "Spain", Convert.ToDateTime("2019-06-01"), 1423, "EUR", 1176.03),
            //    new Computers("Computer", "HP", "Elitebook", "Sweden", Convert.ToDateTime("2020-10-02"), 588, "SEK", 4900),
            //    new Computers("Computer", "Asus", "W234", "USA", Convert.ToDateTime("2017-04-21"), 1200, "USD", 1200),
            //    new Computers("Computer", "Lenovo", "Yoga 730", "USA", Convert.ToDateTime("2018-05-28"), 835, "USD", 835),
            //    new Computers("Computer", "Lenovo", "Yoga 730", "USA", Convert.ToDateTime("2019-05-21"), 1030, "USD", 1030),

            //    new Computers("Phone", "iPhone", "8", "Spain", Convert.ToDateTime("2018-12-29"), 970, "EUR", 801.65),
            //    new Computers("Phone", "iPhone", "11", "Spain", Convert.ToDateTime("2020-09-25"), 990, "EUR", 818.18),
            //    new Computers("Phone", "iPhone", "X", "Sweden", Convert.ToDateTime("2018-07-15"), 1245, "SEK", 10375),
            //    new Computers("Phone", "Motorola", "Razr", "Sweden", Convert.ToDateTime("2020-03-16"), 970, "SEK", 8083.33)
            //};

            ////extraComputer.AddRange(computers);
            //Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) + "Purchase Date".PadRight(15) + "Price in USD".PadRight(15) + "Currency".PadRight(15) + "Local price today" );
            //Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            //foreach (Computers computer in extraComputer)
            //{
            //    Console.WriteLine(computer.Type.PadRight(15) + computer.Brand.PadRight(15) + computer.Model.PadRight(15) + computer.Office.PadRight(15) + computer.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + computer.PriceInUSD.ToString().PadRight(15) + computer.Currency.PadRight(15) + computer.LocalPriceToday.ToString());
            //}

            Console.WriteLine("Asset tracking");
            List<AllAssets> allAssets = new List<AllAssets>();

            //List<Computers> computers = new List<Computers>();

            List<AllAssets> assets = new List<AllAssets>
            {
                new AllAssets("Computer", "HP", "Elitebook", "Spain", Convert.ToDateTime("2019-06-01"), 1423, "EUR", 1176.03),
                new AllAssets("Computer", "HP", "Elitebook", "Sweden", Convert.ToDateTime("2020-10-02"), 588, "SEK", 4900),
                new AllAssets("Computer", "Asus", "W234", "USA", Convert.ToDateTime("2017-04-21"), 1200, "USD", 1200),
                new AllAssets("Computer", "Lenovo", "Yoga 730", "USA", Convert.ToDateTime("2018-05-28"), 835, "USD", 835),

                new AllAssets("Phone", "iPhone", "8", "Spain", Convert.ToDateTime("2018-12-29"), 970, "EUR", 801.65),
                new AllAssets("Phone", "iPhone", "11", "Spain", Convert.ToDateTime("2020-09-25"), 990, "EUR", 818.18),
                new AllAssets("Phone", "iPhone", "X", "Sweden", Convert.ToDateTime("2018-07-15"), 1245, "SEK", 10375),
                new AllAssets("Phone", "Motorola", "Razr", "Sweden", Convert.ToDateTime("2020-03-16"), 970, "SEK", 8083.33),
                new AllAssets("Computer", "Lenovo", "Yoga 730", "USA", Convert.ToDateTime("2019-05-21"), 1030, "USD", 1030)

            };

            Console.WriteLine("My Assets - Unsorted");//extraComputer.AddRange(computers);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) + "Purchase Date".PadRight(15) + "Price in USD".PadRight(15) + "Currency".PadRight(15) + "Local price today");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            foreach (AllAssets asset in assets)
            {
                Console.WriteLine(asset.Type.PadRight(15) + asset.Brand.PadRight(15) + asset.Model.PadRight(15) + asset.Office.PadRight(15) + asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + asset.PriceInUSD.ToString().PadRight(15) + asset.Currency.PadRight(15) + asset.LocalPriceToday.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("My Assets - Sorted by Type");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) + "Purchase Date".PadRight(15) + "Price in USD".PadRight(15) + "Currency".PadRight(15) + "Local price today");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            List<AllAssets> sortedAssets = assets.OrderBy(asset => asset.Type).ToList();

            foreach (AllAssets asset in sortedAssets)
            {
                Console.WriteLine(asset.Type.PadRight(15) + asset.Brand.PadRight(15) + asset.Model.PadRight(15) + asset.Office.PadRight(15) + asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + asset.PriceInUSD.ToString().PadRight(15) + asset.Currency.PadRight(15) + asset.LocalPriceToday.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("My Assets - Sorted by Puschased Date");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) + "Purchase Date".PadRight(15) + "Price in USD".PadRight(15) + "Currency".PadRight(15) + "Local price today");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            List<AllAssets> sortedAssets1 = assets.OrderBy(asset => asset.PurchaseDate).ToList();

            //foreach (AllAssets asset in sortedAssets1)
            //{
                
            //    Console.WriteLine(asset.Type.PadRight(15) + asset.Brand.PadRight(15) + asset.Model.PadRight(15) + asset.Office.PadRight(15) + asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + asset.PriceInUSD.ToString().PadRight(15) + asset.Currency.PadRight(15) + asset.LocalPriceToday.ToString());
            //}

            foreach (AllAssets asset in sortedAssets1)
            {
                bool test = asset.PurchaseDate > DateTime.Now.AddYears(-3).AddMonths(3);
                if (test) Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(asset.Type.PadRight(15) + asset.Brand.PadRight(15) + asset.Model.PadRight(15) + asset.Office.PadRight(15) + asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + asset.PriceInUSD.ToString().PadRight(15) + asset.Currency.PadRight(15) + asset.LocalPriceToday.ToString());
                Console.ResetColor();
            }
            //bool test = b.Year > DateTime.Now.AddYears(-3).AddMonths(3);
            //if (test) Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(b.Type.PadRight(10) + " |" + b.Brand.PadRight(10) + " |" + b.Model.PadRight(20) + " |" + b.Office.PadRight(10) + " |" + b.Year.ToString("yyyy-MM-dd").PadRight(15) + " |" + b.Price.ToString().PadRight(15) + " |" + b.Currency.PadRight(15) + " |" + b.LocalPrice.ToString("C"));
            //Console.ResetColor();

     
























            // Laptop_Computers computer1 = new Laptop_Computers();




            Console.ReadLine();
            
        }
    }
}
