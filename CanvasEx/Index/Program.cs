using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Canvas;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCanvas myCanvas = new MyCanvas();

            //created buttons
            MyCanvas.CreateNewButton(0, 0, 100, 100);
            MyCanvas.CreateNewButton(100, 100, 200, 200);
            MyCanvas.CreateNewButton(200, 200, 300, 300);


            //moved button
            MyCanvas.MoveButton(0, 250, 250, 300, 400);

            //print
            Console.WriteLine(myCanvas.ToString());


            //fetch data
            Console.WriteLine($"Current Number Of Buttons: {MyCanvas.GetCurrentNumberOfButtons()}");
            Console.WriteLine($"Max Number Of Buttons: {MyCanvas.GetMaxNumberOfButtons()}");
            Console.WriteLine($"Max Width Of A Button: {MyCanvas.GetTheMaxWidthOfAButton()}");
            Console.WriteLine($"Max Height Of A Button: {MyCanvas.GetTheMaxHeightOfAButton()}");

            //check if
            Console.WriteLine($"Is Point Inside A Button: {MyCanvas.IsPointInsideAButton(120,120)}");
            Console.WriteLine($"If any buttons is overlapping: {MyCanvas.CheckIfAnyButtonIsOverlapping()}");

            //delete last button
            MyCanvas.DeleteLastButton();
            Console.WriteLine(myCanvas.ToString());

            //clear all buttons
            MyCanvas.ClearAllButtons();
            Console.WriteLine(myCanvas.ToString());

        }
    }
}
