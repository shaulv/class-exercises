using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    abstract class NewsTeam
    {
        #region Properties
        protected Story story;
        #endregion

        #region Methods
        internal abstract void CreateStory();
        public Story GetStory()
        {
            return story;
        }
        internal virtual void AddStyle()
        {
            story.visualStyle = "Default style";
        }
        internal string ToString()
        {
            return $"Story: {story}";
        }
        #endregion
    }
}
