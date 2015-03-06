using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountDLL
{
    public class DiscountSolution:Discount
    {
        IDiscountBehavior discount;
        public override double Calculate(double price)
        {
            if (discount != null)
            {
                return discount.Calculate(price);
            }
        }
    }
}
