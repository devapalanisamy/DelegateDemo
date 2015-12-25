using DelegateDemo.Core.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is awesome");

            Program program = new Program();

            List<Product> products = program.GetListOfProducts();
            ProductFilter pFilter = new ProductSizeFilter(ProductSize.Large);
            IEnumerable<Product> FilteredProducts =  pFilter.ApplyFilter(products);
            foreach (Product product in FilteredProducts)
            {
                Console.WriteLine("Product Color {0} Product Size {1}",product.Color,product.Size);
            }

        }

        public List<Product> GetListOfProducts()
        {
            List<Product> products =  new List<Product>() { };

            Product product01 = new Product() { Size = ProductSize.ExtraLarge, Color = ProductColor.Green };
            Product product02 = new Product() { Size = ProductSize.Large, Color = ProductColor.White };
            Product product03 = new Product() { Size = ProductSize.Medium, Color = ProductColor.Orange };
            Product product04 = new Product() { Size = ProductSize.Small, Color = ProductColor.Voilet };
            Product product05 = new Product() { Size = ProductSize.Medium, Color = ProductColor.Yellow };
            Product product06 = new Product() { Size = ProductSize.Small, Color = ProductColor.Blue };
            Product product07 = new Product() { Size = ProductSize.ExtraLarge, Color = ProductColor.Green };
            Product product08 = new Product() { Size = ProductSize.Large, Color = ProductColor.White };
            Product product09 = new Product() { Size = ProductSize.Small, Color = ProductColor.Blue };
            Product product10 = new Product() { Size = ProductSize.Medium, Color = ProductColor.Blue };
            Product product11 = new Product() { Size = ProductSize.ExtraLarge, Color = ProductColor.Green };
            Product product12 = new Product() { Size = ProductSize.Medium, Color = ProductColor.Green };
            Product product13 = new Product() { Size = ProductSize.Large, Color = ProductColor.Green };
            Product product14 = new Product() { Size = ProductSize.ExtraLarge, Color = ProductColor.Black };
            Product product15 = new Product() { Size = ProductSize.Small, Color = ProductColor.Green };

            products.Add(product01);
            products.Add(product02);
            products.Add(product03);
            products.Add(product04);
            products.Add(product05);
            products.Add(product06);
            products.Add(product07);
            products.Add(product08);
            products.Add(product09);
            products.Add(product10);
            products.Add(product11);
            products.Add(product12);
            products.Add(product13);
            products.Add(product14);
            products.Add(product15);

            return products;

        }
    }
}