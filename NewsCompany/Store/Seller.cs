using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsCompany;

namespace Store
{
    class Seller
    {
        #region Properties
        private int moneyEarned;
        #endregion

        #region Methods
        public void SellNewspaper(Newspaper newspaper)
        {
            moneyEarned += (int)newspaper.price;
        }
        public override string ToString() => $"Money Earned: {moneyEarned}";
        #endregion
    }
}
