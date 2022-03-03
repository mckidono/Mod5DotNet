using System.Collections.Generic;
namespace Mod_5_Northwind.Models
{
        public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description  { get; set; }
        public ICollection<Product> products { get; set; }
    }
}