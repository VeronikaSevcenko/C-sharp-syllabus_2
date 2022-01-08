using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("I am best of the best parrot and i will take this world!");
        }
    }
}
