using System;

namespace DragRace
{
    public class Maserati : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public int SpeedUp()
        {
            return _currentSpeed += 50;
        }

        public int SlowDown()
        {
            return _currentSpeed -= 50;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "Run run run ";
        }

        public int UseNitrousOxideEngine()
        {
            return _currentSpeed += 100;
        }
    }
}
