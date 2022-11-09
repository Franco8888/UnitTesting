using Dapper.Contrib.Extensions;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace Ecommerce_server.Models
{
    [Table("products")]    // dapper.contrib setting table name
    public class Product
    {
        [ExplicitKey]
        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Price { get; set; }  // Will always be the asking price for the product even after discount

        public string? Image { get; set; }

        public string Description { get; set; } = string.Empty;

        public string Brand { get; set; } = string.Empty;

        public ProductCategory Category { get; set; }

        public int Inventory { get; set; }

        public string? ExtraImages { get; set; }

        // Extra - Sale feature
        public int? SalePercentage { get; set; }

        public int? OriginalPrice { get; set; } // Price that was there before the discount

        public DateTime? SaleChanged { get; set; } // Date when last the sale was altered or instantiated 
        // --------------------

        // Extra - BestSellingProducts
        public int Sold { get; set; } = 0;
        // --------------------

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }

    // OFTC - Out of template Change
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProductCategory
    {
        Atomizer,
        Mods,
        Batteries,
        StarterKits,
        VapeJuice,
        CoilsAndPods
    }
}
