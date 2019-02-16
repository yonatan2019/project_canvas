using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyButton 
    {
        protected Point _topleft;
        protected Point _bottomright;
        private int _width;
        private int _height;

        internal MyButton(Point topleft, Point bottomright)
        {
            _topleft = topleft;
            _bottomright = bottomright;
        }

        internal int Getwidth()
        {
            return _width;
        }

        internal int getheight()
        {
            return _height;
        }


        internal bool Settopleft(Point ptl)
        {
            if (_topleft.Getx() < this._bottomright.Getx() && _topleft.Gety() > this._bottomright.Gety())
            {
                this._height = _topleft.Gety() - _bottomright.Gety();
                this._width = _bottomright.Getx() - _topleft.Getx();
                return true;
            }
            return false;
        }


        internal bool Setbuttomright(Point pbr)
        {
            if (_topleft.Getx() < this._bottomright.Getx() && _topleft.Gety() > this._bottomright.Gety())
            {
                this._height = _topleft.Gety() - _topleft.Gety();
                this._width = _bottomright.Getx() - _topleft.Getx();
                return true;
            }
            return false;
        }

        internal Point Gettopleft()
        {
            return _topleft;

        }

        internal Point getbuttomright()
        {
        return _bottomright;

        }

        public override string ToString()
        {
            return $"topleft : {this._topleft} bottomright : {this._bottomright} width : {this._width} height : {this._height}";
        }






    }
}
