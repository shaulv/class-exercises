using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    class GossipTeam : NewsTeam
    {
        #region Constructor
        public GossipTeam()
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
            story.visualStyle = "Gossip style";
        }
        #endregion
    }
}
