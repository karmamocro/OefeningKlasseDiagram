using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgoritmiekOefeningKlasseDiagram
{
    public class Order
    {
        public List<Product> Producten = new List<Product>();

        public double GiveMaximumPrice()
        {
            Stopwatch _sw = new Stopwatch();
            _sw.Start();

            double _max = 0;
            foreach (Product product in Producten)
            {
                _max = (product.Price > _max) ? product.Price : _max;
            }

            _sw.Stop();
            Console.WriteLine($"Getting max price method Elapsed time: {_sw.Elapsed}");
            _sw = null;

            return _max;
        }

        public double GiveAveragePrice()
        {
            Stopwatch _sw = new Stopwatch();
            _sw.Start();

            double _avg = 0;
            foreach (Product product in Producten)
            {
                _avg += product.Price;
            }

            _avg /= Producten.Count > 0 ? Producten.Count : 1;

            _sw.Stop();
            Console.WriteLine($"Getting avarage price method Elapsed time: {_sw.Elapsed}");
            _sw = null;

            return _avg;
        }

        public List<Product> GetAllProducts(double minimumPrice)
        {
            Stopwatch _sw = new Stopwatch();
            _sw.Start();
            List<Product> _producten = new List<Product>();
            Producten.ForEach((p) => { if (p.Price >= minimumPrice) _producten.Add(p); });

            _sw.Stop();
            Console.WriteLine($"Get all products from minimum price method Elapsed time: {_sw.Elapsed}");
            _sw = null;

            return _producten;
        }

        /// <summary>
        /// Efficientie is niet zo goed.. log(n^2) 
        /// tip volgende keer misschien recursive methode gebruiken waarbij ik een locatie update.
        /// </summary>
        public void SortProductsByPrice()
        {
            Stopwatch _sw = new Stopwatch();
            _sw.Start();
            for (int i = 0; i <= Producten.Count - 1; ++i)
            {
                for (int y = 0; y < Producten.Count - 1 - i; y++) // ga voor de 2e keer zo skippen we ook de laatste
                {
                    if (Producten[y].Price > Producten[y + 1].Price) // controleer de grote
                    {
                        Product tmp = Producten[y]; // onthoud de temp waarde

                        Producten[y] = Producten[y + 1]; // shifting 2 positions
                        Producten[y + 1] = tmp;
                    }
                }
            }
            _sw.Stop();
            Console.WriteLine($"Sorting products Elapsed time: {_sw.Elapsed}");
            _sw = null;
        }
    }
}
