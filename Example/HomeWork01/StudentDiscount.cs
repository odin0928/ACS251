using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork01
{
    public class StudentDiscount : Discount
    {
        public override double Calculate(double price)
        {
            return price;
        }
    }
}