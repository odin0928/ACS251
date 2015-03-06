using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDLL
{
    public class CityBankDiscount:IDiscountBehavior
    {
        private double MoneyRebate { get; set; }
        public CityBankDiscount(string moneyRebate)
        {
            MoneyRebate = double.Parse(moneyRebate);
        }
        public override double Calculate(double price)
        {
            return price * MoneyRebate;
        }
    }
}
