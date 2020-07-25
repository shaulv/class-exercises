using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Button
    {
        #region Properties
        protected Point topLeft;
        protected Point bottomRight;
        private int width;
        private int height;
        #endregion

        #region Methods
        public Button(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }
        internal int GetWidth()
        {
            return width;
        }
        internal int GetHeight()
        {
            return height;
        }
        internal bool SetTopLeft(Point point)
        {
            if (point != null)
            {
                this.topLeft = point;
                return true;
            }
            return false;
        }
        internal bool SetBottomRight(Point point)
        {
            if (point != null)
            {
                this.bottomRight = point;
                return true;
            }
            return false;
        }
        internal Point GetTopLeft()
        {
            return topLeft;
        }
        internal Point GetBottomRight()
        {
            return bottomRight;
        }
        public override string ToString()
        {
            return $"Top Left: {this.topLeft}\nBottom Right: {this.bottomRight}\nWidth: {this.width}\nHeight:{this.height}";
        }
        #endregion
    }
}
