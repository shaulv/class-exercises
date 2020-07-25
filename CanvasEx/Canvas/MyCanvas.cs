using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public class MyCanvas
    {
        #region Properties
        public const int maxWidth = 800;
        public const int maxHeight = 600;
        private static int buttonIndex = 0;
        private static int maxButtons = 3;
        private static Button[] buttons = new Button[MyCanvas.maxButtons];
        #endregion

        #region Methods
        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (buttonIndex == maxButtons)
            {
                return false;
            }
            else
            {
                Point point1 = new Point(x1, y1);
                Point point2 = new Point(x2, y2);

                buttons[buttonIndex] = new Button(point1, point2);
                ++buttonIndex;

                return true;
            }
        }

        public static bool MoveButton(int buttonNumber, int x1, int y1, int x2, int y2)
        {
            if (buttonNumber >= maxButtons)
            {
                return false;
            }
            else
            {
                Point point1 = new Point(x1, y1);
                Point point2 = new Point(x2, y2);

                buttons[buttonNumber].SetTopLeft(point1);
                buttons[buttonNumber].SetBottomRight(point2);

                return true;

            }
        }

        public static bool DeleteLastButton()
        {
            if (buttonIndex == 0)
            {
                return false;
            }
            else
            {
                --buttonIndex;
                buttons[buttonIndex] = null;
                return true;
            }
        }

        public static void ClearAllButtons()
        {
            if (buttonIndex != 0)
                for (int i = 0; i < buttonIndex; i++)
                    buttons[i] = null;
        }

        public static int GetCurrentNumberOfButtons()
        {
            return buttonIndex;
        }

        public static int GetMaxNumberOfButtons()
        {
            return maxButtons;
        }

        public static int GetTheMaxWidthOfAButton()
        {
            if (buttonIndex > 0)
            {
                int maxWidth = 0;
                foreach (var btn in buttons)
                {
                    if (btn != null)
                    {
                        int btnWidth = btn.GetWidth();

                        if (btnWidth > maxWidth)
                        {
                            maxWidth = btnWidth;
                        }
                    }
                }
                return maxWidth;
            }
            else
            {
                return 0;
            }
        }

        public static int GetTheMaxHeightOfAButton()
        {
            if (buttonIndex > 0)
            {
                int maxHeight = 0;
                foreach (var btn in buttons)
                {
                    if (btn != null)
                    {
                        int btnHeight = btn.GetHeight();

                        if (btnHeight > maxHeight)
                        {
                            maxHeight = btnHeight;
                        }
                    }
                }
                return maxHeight;
            }
            else
            {
                return 0;
            }
        }

        public static bool IsPointInsideAButton(int x, int y)
        {
            foreach (var btn in buttons)
            {
                if (btn != null)
                {
                    Point bottomRight = btn.GetBottomRight();
                    Point topLeft = btn.GetTopLeft();
                         
                    if (x > topLeft.GetX() && x < bottomRight.GetX() && y > topLeft.GetY() && y < bottomRight.GetY())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {
            for (int i = 0; i < buttonIndex; i++)
            {
                Point btn1BottomRight = buttons[i].GetBottomRight();
                Point btn1TopLeft = buttons[i].GetTopLeft();

                for (int j = 0; j < buttonIndex; j++)
                {
                    Point btn2BottomRight = buttons[j].GetBottomRight();
                    Point btn2TopLeft = buttons[j].GetTopLeft();

                    if ((btn1TopLeft.GetX() >= btn2TopLeft.GetX() && btn1BottomRight.GetX() <= btn2BottomRight.GetX()) && (btn1TopLeft.GetY() >= btn2TopLeft.GetY() && btn1BottomRight.GetY() <= btn2BottomRight.GetY()))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            string str = "";

            foreach (var btn in buttons)
            {
                if (btn != null)
                    str += $"{btn.ToString()}\n\n";
            }
            return str;
        }
        #endregion
    }
}
