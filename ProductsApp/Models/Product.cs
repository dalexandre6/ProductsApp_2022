using System.ComponentModel.DataAnnotations;

namespace ProductsApp.Models
{
    public class Product
    {

        [Key]
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Category { get; set; }
        public int Product_Price { get; set; }

        public string? Product_Description { get; set; }

    }
}
