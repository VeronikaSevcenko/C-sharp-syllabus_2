using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sounds = new List<ISound>
            {
                new Firework(),
                new Parrot(),
                new Radio()
            };

            for (int i = 0; i <= sounds.Count; i++)
            {
                foreach (var s in sounds)
                {

                    Console.WriteLine("\n" + s);

                    s.PlaySound();
                }
            }
        }
    }
}

