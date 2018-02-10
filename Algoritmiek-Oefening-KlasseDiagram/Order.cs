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

        /// <summary>
        /// Efficientie is niet zo goed.. log(n^2) 
        /// </summary>
        public void SortProductsByPrice()
        {
            for (int i = 0; i <= Producten.Count - 1; ++i) {
                for (int j = 0; j < Producten.Count -1 - i; j++) // ga voor de 2e keer er door heen om terug te komen
                {
                    if (Producten[j].Price > Producten[j + 1].Price) // controleer de grote
                    {
                        Product tmp = Producten[j]; // onthoud de temp waarde

                        Producten[j] = Producten[j + 1]; // shifting 2 positions
                        Producten[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
