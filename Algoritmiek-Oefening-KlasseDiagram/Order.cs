using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiekOefeningKlasseDiagram
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
            Producten.ForEach((p) => { if (p.Price >= minimumPrice) _producten.Add(p); });
            return _producten;
        }

        public void SortProductsByPrice()
        {
            List<Product> productsCopy = new List<Product>();
            List<Product> _producten = new List<Product>();

            productsCopy.AddRange(Producten);
            while (productsCopy.Count > 0)
            {
                double max = productsCopy[0].Price;
                for (int i = 0; i < productsCopy.Count -1; i++)
                {
                    if (productsCopy[i].Price > max)
                    {
                        max = productsCopy[i].Price;
                        _producten.Add(productsCopy[i]);
                        productsCopy.Remove(productsCopy[i]);
                        Console.WriteLine($"Wrote the price: {productsCopy[i].Price} to the list");
                    }
                }
            }
            

            foreach (var product in _producten)
            {
                Console.WriteLine($"price: {product.Price}");
            }
        }
    }
}
