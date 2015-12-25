using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo.Core.Source
{
    public enum ProductColor
    {
        Blue,
        Voilet,
        Green,
        Yellow,
        Red,
        Orange,
        Black,
        White
    };

    public enum ProductSize { Small,Medium,Large,ExtraLarge};

    public class Product
    {
        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; }
    }
}
