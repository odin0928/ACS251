using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountDLL
{
    interface IDiscountBehavior
    {
        public double Calculate(double price);
    }
}
