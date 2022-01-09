using System;

namespace DragRace
{
    public class Lexus : ICar
    {
        private int currentSpeed = 0;

        public int SpeedUp() 
        {
            return currentSpeed += 20;
        }

        public int SlowDown() 
        {
            return currentSpeed -= 20;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed += 40;
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}