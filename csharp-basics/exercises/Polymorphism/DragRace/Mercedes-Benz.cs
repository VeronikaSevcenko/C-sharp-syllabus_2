using System;

namespace DragRace
{
    public class Mercedes_Benz : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 30;
        }

        public void SlowDown()
        {
            _currentSpeed -= 40;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("The Best or Nothing");
        }
    }
}
