using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverPosition
{
   public class Rover
    {

        public  Rover(int plateauX , int plateauY, string directionCode, int currentX , int currentY)
        {
            _plateau = new Plateau(plateauX, plateauY);
            _direction = new Direction(directionCode);
            _currentX = currentX;
            _currentY = currentY;
        }

        private Plateau _plateau;
        private Direction _direction;
        private int _currentX;
        private int _currentY;

        public void Process(string processStr)
        {
            for(int i=0;i< processStr.Length;i++)
            {
                if (processStr[i] == 'M')
                {
                    Move();
                }
                else
                {
                    _direction.RotateDirection(processStr[i]);
                }
            }
          
        }
        private void Move()
        {
            int expectedX = _currentX + _direction.DirectionX();
            if (expectedX >= 0 && expectedX <= _plateau.MaxX())
                _currentX = expectedX;
            int expectedY = _currentY + _direction.DirectionY();
            if (expectedY >= 0 && expectedY <= _plateau.MaxY())
                _currentY = expectedY;
        }

        public string GetLastStatus()
        {
            return _currentX.ToString() + " " + _currentY.ToString() + " " + _direction.GetDirectionString();
        }

    }
}
