using System.Collections.Generic;
namespace Mod_5_Northwind.Models
{
        public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit  { get; set; }
        public float UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short ReorderLevel  { get; set; }
        public bool Discontinued {get;set;}

        public int CategoryID {get;set;}

        public Category Category {get;set;}


    }
}