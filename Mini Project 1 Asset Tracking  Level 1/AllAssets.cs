using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_1_Asset_Tracking__Level_1
{
    internal class AllAssets
    {
        public AllAssets(string type, string brand,
            string model, string office, DateTime purchaseDate,
            double priceInUSD, string currency, double localPriceToday)
        {

            Type = type;
            Brand = brand;
            Model = model;
            Office = office;
            PurchaseDate = purchaseDate;
            PriceInUSD = priceInUSD;
            Currency = currency;
            LocalPriceToday = localPriceToday;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Office { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PriceInUSD { get; set; }
        public string Currency { get; set; }
        public double LocalPriceToday { get; set; }
    }
}
