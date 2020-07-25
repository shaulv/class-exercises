using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Point
    {
        #region Properties
        private int x;
        private int y;
        #endregion

        #region Constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Methods
        internal int GetX()
        {
            return x;
        }
        internal void SetX(int x)
        {
            this.x = x;
        }
        internal int GetY()
        {
            return y;
        }
        internal void SetY(int y)
        {
            this.y = y;
        }
        public override string ToString()
        {
            return $"X: {this.x} Y: {this.y}";
        }
        #endregion
    }
}
