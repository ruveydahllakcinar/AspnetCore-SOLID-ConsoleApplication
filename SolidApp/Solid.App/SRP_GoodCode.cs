using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.App.SRP_GoodCode
{
  

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class ProductRepository
        {

            private static List<Product> ProductsList = new List<Product>();

            public List<Product> GetProducts => ProductsList;
            public ProductRepository()
            {
                ProductsList = new()
                {
                    new(){Id = 1, Name="Pencil"},
                    new(){Id = 2, Name="Pencil 2"},
                    new(){Id = 3, Name="Pencil 3 "},
                    new(){Id = 4, Name="Pencil 4 "},
                    new(){Id = 5, Name="Pencil 5 "},
                    new(){Id = 6, Name="Pencil 6 "},
                };
            }
            public void SaveorUpdate(Product product)
            {
                var hasProduct = ProductsList.Any(p => p.Id == product.Id);
                if (!hasProduct)
                {
                    ProductsList.Add(product);
                }
                else
                {
                    var index = ProductsList.FindIndex(x => x.Id == product.Id);
                    ProductsList[index] = product;
                }
            }

            public void Delete(int id)
            {
                var hasProduct = ProductsList.Find(x => x.Id == id);
                if (hasProduct == null)
                {
                    throw new Exception("Ürün bulunamadı");
                }
                ProductsList.Remove(hasProduct);
            }


        }

        public class ProductPresenter
        {
            public void WriteToConsole(List<Product> ProductList)
            {
                ProductList.ForEach(x =>
                {
                    Console.WriteLine($"{x.Id}-{x.Name}");
                });
            }
        }
    
}
   

