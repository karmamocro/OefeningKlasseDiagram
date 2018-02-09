using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmiekOefeningKlasseDiagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product1 = new Product("Juice", 3);
            var product2 = new Product("Cake", 1);
            var product3 = new Product("Milk", 2);
            var product4 = new Product("Chips", 5);
            var product5 = new Product("Sugar", 2);

            var newOrder = new Order();

            // act
            newOrder.Producten.Add(product1);
            newOrder.Producten.Add(product2);
            newOrder.Producten.Add(product3);
            newOrder.Producten.Add(product4);
            newOrder.Producten.Add(product5);

            newOrder.SortProductsByPrice();
        }
    }
}
