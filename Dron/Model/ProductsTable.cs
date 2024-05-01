using Dron.Model.Models22;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dron.Model
{
    internal class ProductsTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public int? Price { get; set; }
        public string CategoryName { get; set; }


        public static ProductsTable ConvertProductsOnProductsTable(Products products)
        {
            ProductsTable productsTable = new ProductsTable();
            productsTable.Id = products.Id;
            productsTable.Name = products.Name;
            productsTable.CategoryId = products.CategoryId;
            productsTable.Price = products.Price;

            using (ApplicationContext db = new ApplicationContext())
            {
                productsTable.CategoryName = db.Categories.FirstOrDefault(g => g.Id == products.CategoryId).Name;
            }

            return productsTable;
        }
    }
}
