using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Story
    {
        #region Properties
        public string title;
        public string body;
        public string visualStyle;
        #endregion  

        #region Constructor
        public Story()
        {
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Title: {title} \n Body: {body}";
        }
        #endregion
    }
}
