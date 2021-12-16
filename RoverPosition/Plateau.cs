using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverPosition
{
  public  class Plateau
    {
        public Plateau(int x,int y)
        {
            _maxX = x;
            _maxY = y;
        }


        private int _maxX;
        private int _maxY;
        public int MaxX()
        {
            return _maxX; 
        }
        public int MaxY()
        {
            return _maxY;
        }



    }



}
