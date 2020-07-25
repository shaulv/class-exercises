using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewsCompany
{
    public class Newspaper
    {
        #region Properties
        private Story[] stories;
        private float price;

        public int Length { get; internal set; }
        #endregion

        #region Constructor
        public Newspaper()
        {
            this.price = 0;
        }
        #endregion

        #region Methods
        public Story[] GetStories()
        {
            if (stories != null)
                return stories;

            return null;
        }

        public void SetStories(Story[] stories) => this.stories = stories;

        public float GetPrice() => this.price;

        public void SetPrice(float price) => this.price = price;

        public void Read()
        {
            foreach (var story in stories)
                Console.WriteLine(story.ToString());
        }

        public override string ToString()
        {
            string _stories = "";
            foreach (var story in stories)
            {
                _stories += $"{story.ToString()}\n\n";
            }

            return $"Price: {price}\n\nStories:\n\n{_stories}";
        }
        #endregion
    }
}
