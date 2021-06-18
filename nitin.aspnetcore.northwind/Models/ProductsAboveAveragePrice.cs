using System;
using System.Collections.Generic;

#nullable disable

namespace nitin.aspnetcore.northwind.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
