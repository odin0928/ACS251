using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork01
{
    public class MovieTicket
    {
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private Discount discount;

        public void SetDiscount(Discount discount)
        {
        }

        public void set_Price(double value)
        {
        }

        public double get_Price()
        {
            return Price;
        }
    }
}