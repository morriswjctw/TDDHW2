using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    public class Bill
    {
        /// <summary>
        /// 折扣
        /// </summary>
        public Dictionary<int, double> Discount =
            new Dictionary<int, double>(){
                {1, 1},
                {2, 0.95},
                {3, 0.9},
                {4, 0.8},
                {5, 0.75}
            };

        /// <summary>
        /// 計算總價
        /// </summary>
        /// <param name="Product">購買清單</param>
        /// <returns></returns>
        internal int Checkout(List<Potter> Product)
        {
            int BookGroupCount = Product.Sum(c => c.Amount);
            int Total = Convert.ToInt32(Product.Select(c => c.Amount * c.Price).Sum() * Discount[BookGroupCount]);
            return Total;
        }
    }
}
