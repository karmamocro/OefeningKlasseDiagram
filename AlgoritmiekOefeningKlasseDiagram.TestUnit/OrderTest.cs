﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmiekOefeningKlasseDiagram;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritmiekOefeningKlasseDiagram.TestUnit
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void SortProductsByPrice_SortingProducts_EqualsToExpectectation()
        {
            // arrange
            var product1_4 = new Product("Juice", 3);
            var product2_1 = new Product("Cake", 1);
            var product3_2 = new Product("Milk", 2);
            var product4_5 = new Product("Chips", 5);
            var product5_3 = new Product("Sugar", 2);

            var newOrder = new Order();

            newOrder.Producten.Add(product1_4);
            newOrder.Producten.Add(product2_1);
            newOrder.Producten.Add(product3_2);
            newOrder.Producten.Add(product4_5);
            newOrder.Producten.Add(product5_3);

            // act
            newOrder.SortProductsByPrice();
            var result1 = (newOrder.Producten[0] == product2_1);
            var result2 = (newOrder.Producten[1] == product3_2);
            var result3 = (newOrder.Producten[2] == product5_3);
            var result4 = (newOrder.Producten[3] == product1_4);
            var result5 = (newOrder.Producten[4] == product4_5);


            // assert
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.IsTrue(result4);
            Assert.IsTrue(result5);
        }

        [TestMethod]
        public void GiveMaximumPrice_Adding5Products_ReturnHighestNumber()
        {
            // arrange
            var product1_4 = new Product("Juice", 3);
            var product2_1 = new Product("Cake", 1);
            var product3_2 = new Product("Milk", 2);
            var product4_5 = new Product("Chips", 5);
            var product5_3 = new Product("Sugar", 2);

            var newOrder = new Order();

            newOrder.Producten.Add(product1_4);
            newOrder.Producten.Add(product2_1);
            newOrder.Producten.Add(product3_2);
            newOrder.Producten.Add(product4_5);
            newOrder.Producten.Add(product5_3);

            double HighestPriceExpected = 5;

            // act
            var HighestPriceActual = newOrder.GiveMaximumPrice();


            // assert
            Assert.AreEqual<double>(HighestPriceExpected, HighestPriceActual);
        }

        [TestMethod]
        public void GiveAvargePrice_Adding4Products_ReturnAvaragePrice()
        {
            // arrange
            var product1_4 = new Product("Juice", 3);
            var product2_1 = new Product("Cake", 1);
            var product3_2 = new Product("Milk", 2);
            var product4_5 = new Product("Chips", 5);
            var product5_3 = new Product("Sugar", 2);

            var newOrder = new Order();

            newOrder.Producten.Add(product1_4);
            newOrder.Producten.Add(product2_1);
            newOrder.Producten.Add(product3_2);
            newOrder.Producten.Add(product4_5);
            newOrder.Producten.Add(product5_3);

            double AvgPriceExpected = 2.6;

            // act
            var AvgPriceActual = newOrder.GiveAveragePrice();


            // assert
            Assert.AreEqual<double>(AvgPriceExpected, AvgPriceActual);
        }

        [TestMethod]
        public void GetAllProducts_Adding4ProductsDefiningingMinimum_ReturnTrue()
        {
            // arrange
            var product1_4 = new Product("Juice", 3);
            var product2_1 = new Product("Cake", 1);
            var product3_2 = new Product("Milk", 2);
            var product4_5 = new Product("Chips", 5);
            var product5_3 = new Product("Sugar", 2);

            var newOrder = new Order();

            newOrder.Producten.Add(product1_4);
            newOrder.Producten.Add(product2_1);
            newOrder.Producten.Add(product3_2);
            newOrder.Producten.Add(product4_5);
            newOrder.Producten.Add(product5_3);

            double MinimumPrice = 2;

            // act
            IEnumerable<Product> returnedList = newOrder.GetAllProducts(MinimumPrice).Where(p => p == product2_1);
            bool result = returnedList.Any() ? true : false;

            // assert
            Assert.IsFalse(result);
        }

    }
}
