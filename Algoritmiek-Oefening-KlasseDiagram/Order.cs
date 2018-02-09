using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmiek_Oefening_KlasseDiagram
{
    public class Order
    {
        public List<Product> Producten = new List<Product>();

        public double GiveMaximumPrice()
        {
            double _max = 0;
            foreach (Product product in Producten)
            {
                _max = (product.Price > _max) ? product.Price : _max; 
            }
            return _max;
        }

        public double GiveAveragePrice()
        {
            double _avg = 0;
            foreach (Product product in Producten)
            {
                _avg += product.Price;
            }

            _avg /= Producten.Count > 0 ? Producten.Count : 1;
            return _avg;
        }

        public List<Product> GetAllProducts(double minimumPrice)
        {
            List<Product> _producten = new List<Product>();
            foreach (Product product in Producten)
            {
                _producten.Add(product.Price >= minimumPrice ? product : null);
                //(product.Price >= minimumPrice) ? _producten.Add(product) : null 
                //if(product.Price >= minimumPrice) { _producten.Add(product); }
            }
            return _producten;
        }
    }
}
