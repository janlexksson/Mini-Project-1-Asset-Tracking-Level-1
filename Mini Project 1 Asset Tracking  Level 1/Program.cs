using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Project_1_Asset_Tracking__Level_1
{
    internal class Program
    {
        static void Title(string input)//Method writing Title input with  titlerow
        {
            Console.WriteLine(input);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Type".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Office".PadRight(15) + "Purchase Date".PadRight(15) + "Price in USD".PadRight(15) + "Currency".PadRight(15) + "Local price today");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");
        }

        static void PrintAssets(List<AllAssets> list)//Method printing output from list
        {
            foreach (AllAssets asset in list)
            {
                Console.WriteLine(asset.Type.PadRight(15) + asset.Brand.PadRight(15) + asset.Model.PadRight(15) + asset.Office.PadRight(15) + asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + asset.PriceInUSD.ToString().PadRight(15) + asset.Currency.PadRight(15) + asset.LocalPriceToday.ToString());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<AllAssets> assets = new List<AllAssets>//Hardcoded assets in List
            {
                new AllAssets("Computer", "HP", "Elitebook", "Spain", Convert.ToDateTime("2019-06-01"), 1423, "EUR", 1176.03),
                new AllAssets("Computer", "HP", "Elitebook", "Sweden", Convert.ToDateTime("2020-10-02"), 588, "SEK", 4900),
                new AllAssets("Computer", "Asus", "W234", "USA", Convert.ToDateTime("2017-04-21"), 1200, "USD", 1200),
                new AllAssets("Computer", "Lenovo", "Yoga 730", "USA", Convert.ToDateTime("2018-05-28"), 835, "USD", 835),

                new AllAssets("Phone", "iPhone", "8", "Spain", Convert.ToDateTime("2018-12-29"), 970, "EUR", 801.65),
                new AllAssets("Phone", "iPhone", "11", "Spain", Convert.ToDateTime("2020-09-25"), 990, "EUR", 818.18),
                new AllAssets("Phone", "iPhone", "X", "Sweden", Convert.ToDateTime("2018-07-15"), 1245, "SEK", 10375),
                new AllAssets("Phone", "Motorola", "Razr", "Sweden", Convert.ToDateTime("2020-03-16"), 970, "SEK", 8083.33),
                new AllAssets("Computer", "Lenovo", "Yoga 730", "USA", Convert.ToDateTime("2019-05-21"), 1030, "USD", 1030),
                new AllAssets("Computer", "Lenovo", "Yoga 730", "USA", Convert.ToDateTime("2019-10-08"), 1030, "USD", 1030),
                new AllAssets("Computer", "Lenovo", "Yoga 730", "USA", Convert.ToDateTime("2019-07-08"), 1030, "USD", 1030)

            };
            List<AllAssets> sortedAssets = new List<AllAssets>();
            string type = "", brand = "", model = "", office = "";
            DateTime dateTime = new DateTime();
            double price = 0;

            while (true)
            {
                
                    Console.WriteLine("Write the type (Phone or Computer). Write 'exit' to exit!");
                    type = Console.ReadLine();
                    if (type.ToLower().Trim() == "exit")
                    {
                        break;
                    }
                    Console.WriteLine("What is the brand?");
                    brand = Console.ReadLine();

                    Console.WriteLine("What is the model?");
                    model = Console.ReadLine();

                    Console.WriteLine("What is the office: Sweden, Spain or USA?");
                    office = Console.ReadLine();

                    Console.WriteLine("What is the datetime?");
                    dateTime = Convert.ToDateTime(Console.ReadLine());
                
                try
                {
                    Console.WriteLine("What is the price: i USD?");
                    price = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Skriv nummer!");
                    break;
                }
                
                



                assets.Add(new AllAssets(type, brand, model, office, dateTime, price, "", 0));//Adding user input to list
            }
            


            Console.WriteLine("Asset tracking");

            //List<Computers> computers = new List<Computers>();

            // Diffrent output from list with methods
            Title("My Assets unsorted");
            PrintAssets(assets);

            sortedAssets = assets.OrderBy(asset => asset.Type).ToList();
            Title("My Assets  - Sorted by Type");
            PrintAssets(sortedAssets);

            sortedAssets = assets.OrderBy(asset => asset.PurchaseDate).ToList();
            Title("My Assets - Sorted by Puschased Date");
            PrintAssets(sortedAssets);


            Console.WriteLine();
            Title("My Assets - Sorted by Puschased Date less than 3 months(Red) away from 3 years");

            sortedAssets = assets.OrderBy(asset => asset.PurchaseDate).ToList();
            foreach (AllAssets asset in sortedAssets)
            {
                bool test = asset.PurchaseDate > DateTime.Now.AddYears(-3).AddMonths(3);
                if (test) Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(asset.Type.PadRight(15) + asset.Brand.PadRight(15) + asset.Model.PadRight(15) + asset.Office.PadRight(15) + asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + asset.PriceInUSD.ToString().PadRight(15) + asset.Currency.PadRight(15) + asset.LocalPriceToday.ToString());
                Console.ResetColor();
            }
            Console.WriteLine();


            sortedAssets = assets.OrderBy(asset => asset.PurchaseDate).ToList();
            Title("My Assets - Sorted by Puschased Date less than 3 months(Red) 6 months(Yellow) away from 3 years");
            foreach (AllAssets asset in sortedAssets)
            {
                bool test = asset.PurchaseDate > DateTime.Now.AddYears(-3).AddMonths(3);
                if (test) Console.ForegroundColor = ConsoleColor.Red;
                bool test1 = asset.PurchaseDate > DateTime.Now.AddYears(-3).AddMonths(6);
                if (test1) Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(asset.Type.PadRight(15) + asset.Brand.PadRight(15) + asset.Model.PadRight(15) + asset.Office.PadRight(15) + asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + asset.PriceInUSD.ToString().PadRight(15) + asset.Currency.PadRight(15) + asset.LocalPriceToday.ToString());
                Console.ResetColor();
            }

            Console.WriteLine();
            Title("My Assets - Sorted by Office Puschased Date less than 3 months(Red) 6 months(Yellow) away from 3 years");
            List<AllAssets> sortedAssets2 = assets.OrderBy(asset => asset.Office).ThenBy(asset => asset.PurchaseDate).ToList();
            foreach (AllAssets asset in sortedAssets2)
            {
                // sortedAssets2 = assets.OrderBy(asset => asset.PurchaseDate).ToList();


                bool test = asset.PurchaseDate < DateTime.Now.AddYears(-3).AddMonths(3);
                bool test1 = asset.PurchaseDate < DateTime.Now.AddYears(-3).AddMonths(6);
                //bool test2 = asset.PurchaseDate < DateTime.Now.AddYears(-3);

                //if (test2) Console.ForegroundColor = ConsoleColor.Magenta;
                if (test) Console.ForegroundColor = ConsoleColor.Red;
                else if (test1) Console.ForegroundColor = ConsoleColor.Yellow;

                if (asset.Office.ToLower() == "sweden")
                {
                    asset.LocalPriceToday = asset.PriceInUSD * 10d;
                    asset.Currency = "SEK";
                }
                else if (asset.Office.ToLower() == "spain")
                {
                    asset.LocalPriceToday = asset.PriceInUSD * 0.95;
                    asset.Currency = "EUR";
                }
                else if (asset.Office.ToLower() == "usa")
                { 
                    asset.LocalPriceToday = asset.PriceInUSD;
                    asset.Currency = "USD";

                }


                Console.WriteLine(asset.Type.PadRight(15) + asset.Brand.PadRight(15) + asset.Model.PadRight(15) + asset.Office.PadRight(15) + asset.PurchaseDate.ToString("yyyy-MM-dd").PadRight(15) + asset.PriceInUSD.ToString().PadRight(15) + asset.Currency.PadRight(15) + asset.LocalPriceToday.ToString());
                Console.ResetColor();
            }



























            // Laptop_Computers computer1 = new Laptop_Computers();




            Console.ReadLine();

        }
    }
}
