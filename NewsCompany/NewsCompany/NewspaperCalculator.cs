using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    static class NewspaperCalculator
    {
        #region Methods
        internal static int CalcNumberOfChars(Newspaper newsPaper)
        {
            return newsPaper.title.Length + newsPaper.body.Length;
        }
        #endregion
    }
}
