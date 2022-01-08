using System;

namespace DragRace
{
    class Maserati : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 50;
        }

        public void SlowDown()
        {
            _currentSpeed -= 50;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Run run run ");
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 100;
        }
    }
}
