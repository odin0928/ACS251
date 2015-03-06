using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDLL
{
    public class UnderYearDiscount:Discount
    {
        private double MoneyRebate { get; set; }
        public UnderYearDiscount(string moneyRebate)
        {
            MoneyRebate=double.Parse(moneyRebate);
        }

        public override double Calculate(double price)
        {
            return price * MoneyRebate;
        }
    }
}
