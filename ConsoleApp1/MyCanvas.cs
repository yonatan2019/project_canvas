using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static public class MyCanvas
    {
        public const int MAXW = 800;
        public const int MAXH = 600;
        private static int buttonindex = 0;
        private static MyButton[] buttons = new MyButton[MaxButtons];
        private static int MaxButtons = 3;

        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (buttonindex < MaxButtons && x1 < MAXW && x1 > 0 && x2 > 0 && x2 < MAXW && y1 < MAXH && y1 > 0 && y2 < MAXH && y2 > 0)
            {
                MyButton Newbutton = new MyButton(new Point(x1, y1), new Point(x2, y2));
                if (Newbutton.Setbuttomright(new Point(x1, y1)) && Newbutton.Settopleft(new Point(x2, y2)))
                {
                    buttons[buttonindex] = Newbutton;
                    buttonindex++;
                    return true;
                }

            }

            return false;
        }

        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            if (buttonNumber <= buttonindex)
            {
                int newXTop = buttons[buttonNumber].Gettopleft().Getx() + x;
                int newYTop = buttons[buttonNumber].Gettopleft().Gety() + y;
                int newXBottom = buttons[buttonNumber].getbuttomright().Getx() + x;
                int newYBottom = buttons[buttonNumber].getbuttomright().Gety() + y;
                MyButton moveButton = new MyButton(new Point(newXTop, newYTop), new Point(newXBottom, newYBottom));
                return true;
            }
            return false;

        }

        public static bool DeleteLastButton()
        {
            if (buttons[buttonindex - 1] == null)
            {
                return false;
            }
            else
            {
                buttons[buttonindex - 1] = null;
                buttonindex--;
                return true;
            }

        }

        public static void ClearAllButton()
        {
            if (buttonindex > 0)
            {
                buttons = new MyButton[MaxButtons];
                buttonindex = 0;
            }
        }

        public static int GetCurrentNumberOfButtons()
        {
            return buttonindex;
        }

        public static int GetMaxNumberOfButtons()
        {
            return MaxButtons;
        }

        public static int GetTheMaxWidthOfAButton()
        {
            int maxWidth = 0;
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].Getwidth() > maxWidth)
                {
                    maxWidth = buttons[i].Getwidth();
                }
            }
            return maxWidth;
        }

        public static int GetTheMaxHeightOfAButton()
        {
            int maxHeight = 0;
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].getheight() > maxHeight)
                {
                    maxHeight = buttons[i].getheight();
                }
            }
            return maxHeight;
        }

        public static void PrintButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                Console.Write("Top left x: " + buttons[i].Gettopleft().Getx());
                Console.WriteLine("Top left y: " + buttons[i].Gettopleft().Gety());
                Console.Write("Bottom right x: " + buttons[i].getbuttomright().Getx());
                Console.WriteLine("bottom right y: " + buttons[i].getbuttomright().Gety());

            }
        }

        public static bool IsPointInsideAButton(int x, int y)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (x < buttons[i].Gettopleft().Getx() || (x > buttons[i].getbuttomright().Getx() && y > buttons[i].Gettopleft().Gety()) || y < buttons[i].getbuttomright().Gety())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                int area = CalcAreaBotton(buttons[i].getheight(), buttons[i].Getwidth());
                for (int B = i + 1; B < buttons.Length; B++)
                {
                    if (area == CalcAreaBotton(buttons[B].getheight(), buttons[B].Getwidth()))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        internal static int CalcAreaBotton(int x, int y)
        {
            int area = x * y;
            return area;
        }

        





    }
}
