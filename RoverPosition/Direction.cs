using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverPosition
{
   public  class Direction
    {

        private int _directionX;
        private int _directionY;

        public int DirectionX()
        {
            return _directionX;
        }
        public int DirectionY()
        {
            return _directionY;
        }
        public Direction(string directionCode)
        {


            switch(directionCode)
            {
                case "N":
                    _directionX = 0;
                    _directionY = 1;
                    break;
                case "E":
                    _directionX = 1;
                    _directionY = 0;
                    break;
                case "S":
                    _directionX = 0;
                    _directionY = -1;
                    break;
                case "W":
                    _directionX = -1;
                    _directionY = 0;
                    break;
            }
        }

        public void RotateDirection(char direction)
        {
            int currentDirX = _directionX;
            int currentDirY = _directionY;
            double dirAngle;

            if (direction == 'R')
            {
                dirAngle = -1 * (Math.PI / 2); 

            }
            else
            {
                dirAngle = Math.PI / 2;
            }

            _directionX = (int)((double)currentDirX * Math.Cos(dirAngle) - (double)currentDirY * Math.Sin(dirAngle));
            _directionY = (int)((double)currentDirX * Math.Sin(dirAngle) + (double)currentDirY * Math.Cos(dirAngle));


        }

        public string GetDirectionString()
        {
            string result = string.Empty;
            if (_directionX == 0 && _directionY == 1)
                result = "N";
            else if (_directionX == 1 && _directionY == 0)
                result = "E";
            else if (_directionX == 0 && _directionY == -1)
                result = "S";
            else 
                result = "W";
            return result;
        }




    }
}
