using Dron.Model.Models22;
using Dron.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dron.Model
{
    static class DataWorker
    {
        //Products
        public static bool CreateProducts(string name, int? category_id, int? price)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (!db.Products.Any(el => el.Name == name))
                {
                    Products products = new Products()
                    {
                        Name = name,
                        CategoryId = category_id,
                        Price = price,

                    };
                    db.Products.Add(products);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static void DeleteProducts(Products products)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Products.Remove(products);
                db.SaveChanges();
            }
        }

        public static bool EditProducts(Products oldProducts, string newName, int newCategory_id, int newPrice)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Products products = db.Products.FirstOrDefault(i => i.Id == oldProducts.Id);
                if (products != null)
                {
                    products.Name = newName;
                    products.CategoryId = newCategory_id;
                    products.Price = newPrice;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static List<Products> SelectAllProducts()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Products.ToList();
            }
        }


        //Orders
        public static bool CreateOrders(int users_id, string status, int worker_id, int created_at)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (!db.Orders.Any(p => p.UsersId == users_id && p.Status == status && p.WorkerId == worker_id && p.CreatedAt == created_at))
                {
                    Orders orders = new Orders()
                    {
                        UsersId = users_id,
                        Status = status,
                        WorkerId = worker_id,
                        CreatedAt = created_at,
                    };
                    db.Orders.Add(orders);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static void DeleteOrders(Orders orders)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Orders.Remove(orders);
                db.SaveChanges();
            }
        }

        public static bool EditOrders(Orders oldOrders, int newUsers_id, string newStatus, int newWorker_id, int newCreated_at)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Orders orders = db.Orders.FirstOrDefault(i => i.Id == oldOrders.Id);
                if (orders != null)
                {
                    orders.UsersId = newUsers_id;
                    orders.Status = newStatus;
                    orders.WorkerId = newWorker_id;
                    orders.CreatedAt = newCreated_at;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public static List<Orders> SelectAllOrders()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Orders.ToList();
            }
        }

        //Client
        public static bool CreateClient(string name, int telephoneNumber, string address)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (!db.Client.Any(p => p.Name == name && p.TelephoneNumber == telephoneNumber && p.Address == address))
                {
                    Client client = new Client()
                    {
                        Name = name,
                        TelephoneNumber = telephoneNumber,
                        Address = address,
                    };
                    db.Client.Add(client);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static void DeleteClient(Client client)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Client.Remove(client);
                db.SaveChanges();
            }
        }

        public static bool EditClient(Client oldClient, string newName, int newTelephoneNumber, string newAddress)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Client client = db.Client.FirstOrDefault(i => i.IdClient == oldClient.IdClient);
                if (client != null)
                {
                    client.Name = newName;
                    client.Address = newAddress;
                    client.TelephoneNumber = newTelephoneNumber;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static List<Client> SelectAllClient()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Client.ToList();
            }
        }





        //Categories
        public static void CreateCategories(string name)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (!db.Categories.Any(el => el.Name == name))
                {
                    Categories categories = new Categories()
                    {
                        Name = name,
                    };
                    db.Categories.Add(categories);
                    db.SaveChanges();
                }
            }
        }

        public static void DeleteCategories(Categories categories)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Categories.Remove(categories);
                db.SaveChanges();
            }
        }

        public static void EditCategories(Categories oldCategories, string newName)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Categories categories = db.Categories.FirstOrDefault(i => i.Id == oldCategories.Id);
                if (categories != null)
                {
                    categories.Name = newName;
                    db.SaveChanges();
                }
            }
        }

        public static List<Categories> SelectAllCategories()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Categories.ToList();
            }
        }

        //ProductsTable
        public static List<ProductsTable> SelectAllProductsTable()
        {
            List<Products> products = SelectAllProducts();
            List<ProductsTable> productsTables = new List<ProductsTable>();
            foreach (Products product in products)
            {
                productsTables.Add(ProductsTable.ConvertProductsOnProductsTable(product));
            }
            return productsTables;
        }

        //OrdersTable
        public static List<OrdersTable> SelectAllOrdersTable()
        {
            List<Orders> orders = SelectAllOrders();
            List<OrdersTable> ordersTables = new List<OrdersTable>();
            foreach (var order in orders)
            {
                ordersTables.Add(OrdersTable.ConvertOrdersOnOrdersTable(order));
            }
            return ordersTables;
        }
        public static List<Workers> SelectAllWorkers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Workers.ToList();
            }
        }
    }
}
