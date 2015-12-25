using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Core.Source
{
    public class ProductColorFilter : ProductFilter
    {
        private ProductColor FilterColor;

        public  ProductColorFilter(ProductColor productColor)
        {
            this.FilterColor = productColor;
        }

        public override IEnumerable<Product> ApplyFilter(List<Product> Products)
        {
           foreach ( Product product in Products)
           {
               if(product.Color == FilterColor)
                   yield return product ;
           }
        }
    }
}
