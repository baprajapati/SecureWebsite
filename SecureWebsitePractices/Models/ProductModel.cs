using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecureWebsitePractices.Models
{
    public class ProductModel
    {
        public string ProductKey { get; set; }
        public string ProductAlternateKey { get; set; }
        public string ProductName { get; set; }
        public int StockLevel { get; set; }
        public string Searched { get; set; }
        public bool SearchedById { get; set; }
        public bool SearchedByName { get; set; }


        public List<ProductModel> ProductList { get; set; }

    }
}