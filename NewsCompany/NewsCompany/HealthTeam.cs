using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    class HealthTeam : NewsTeam
    {
        #region Constructor
        public HealthTeam()
        {

        }
        #endregion

        #region Methods
        internal override void CreateStory()
        {
            story = new Story();
        }
        internal override void AddStyle()
        {
            story.visualStyle = "Health style";
        }
        #endregion
    }
}
