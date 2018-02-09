using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmiekOefeningKlasseDiagram;

namespace AlgoritmiekOefeningKlasseDiagram.TestUnit
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void SortProductsByPrice_SortingProducts_EqualsToExpectectation()
        {
            // arrange
            var product1 = new Product("Juice", 3);
            var product2 = new Product("Cake", 1);
            var product3 = new Product("Milk", 2);
            var product4 = new Product("Chips", 5);

            var newOrder = new Order();

            // act
            newOrder.Producten.Add(product1);
            newOrder.Producten.Add(product2);
            newOrder.Producten.Add(product3);
            newOrder.Producten.Add(product4);


            // assert
        }
    }
}
