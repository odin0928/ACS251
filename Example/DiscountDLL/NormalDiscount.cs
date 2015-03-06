using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDLL
{
    /// <summary>
    /// 一般打折
    /// </summary>
    public class NormalDiscount
    {
        private double MoneyRebate { get; set; }
        public NormalDiscount(string moneyRebate)
        {
            MoneyRebate = double.Parse(moneyRebate);
        }

        public override double Calculate(double price)
        {
            return price * MoneyRebate;
        }
    }
}
