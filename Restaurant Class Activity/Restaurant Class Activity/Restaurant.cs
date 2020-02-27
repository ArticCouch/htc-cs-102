using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Restaurant_Class_Activity
{
    class Restaurant
    {
        public string NameOfFood;
        public double PriceOfFood;
        public int quantity;

        public void Menu()
        {
            MessageBox.Show("You have bought " + NameOfFood + " It costs " + PriceOfFood + " you have ordered a quantity of " +  quantity);
        } 
    }
}
