using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDLL
{
    /// <summary>
    /// 折扣抽象類別
    /// </summary>
    internal abstract class Discount
    {
        
        public abstract double Calculate(double price);
    }
}