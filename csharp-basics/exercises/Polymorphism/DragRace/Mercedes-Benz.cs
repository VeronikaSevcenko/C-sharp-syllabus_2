using System;

namespace DragRace
{
    public class Mercedes_Benz : ICar
    {
        private int _currentSpeed = 0;

        public int SpeedUp()
        {
           return _currentSpeed += 30;
        }

        public int SlowDown()
        {
            return _currentSpeed -= 40;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "The Best or Nothing";
        }
    }
}
