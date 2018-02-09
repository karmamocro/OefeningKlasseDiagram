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
            for (int i = 0; i <= Producten.Count - 1; ++i) {
                if (i + 1 == Producten.Count)  break;  // break out of loop when end is reached.
                if (Producten[i].Price > Producten[i + 1].Price)
                {
                    Product tmp = Producten[i];

                    Producten[i] = Producten[i + 1]; // shifting 2 positions
                    Producten[i + 1] = tmp;
                }
                // TODO: when the loop is at the end loop backwards to sort again 
                // TODO: fix so when 2 values are equal stay at the same position


            }
            

            foreach (var product in Producten)
            {
                Console.WriteLine($"price: {product.Price}");
            }
        }
    }
}
