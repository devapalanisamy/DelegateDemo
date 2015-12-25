using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Core.Source
{
    public abstract class ProductFilter
    {
        public abstract IEnumerable<Product> ApplyFilter(List<Product> Products);
    }
}
