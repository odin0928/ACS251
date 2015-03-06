using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork01
{
    public class BoyDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price;
        }
    }
}