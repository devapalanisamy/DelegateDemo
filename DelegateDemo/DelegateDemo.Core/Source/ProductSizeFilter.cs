using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Core.Source
{
    class ProductSizeFilter : ProductFilter
    {
        public ProductSize SizeFilter;

        public  ProductSizeFilter(ProductSize productSize)
        {
           this.SizeFilter = productSize ;
        }

        public override IEnumerable<Product> ApplyFilter(List<Product> Products)
        {
            foreach(Product Product in Products)
            {
                if((Product.Size == SizeFilter))
                    yield return Product;
            }
        }
    }
}
