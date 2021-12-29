using System;

namespace ex9Classes
{
    class Point
    {
        public int x;
        public int y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }
    public class SwapPoints
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            swapPoints(p1, p2);
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
        }
        private static void swapPoints(Point p1, Point p2)
        {
            p1.x ^= p2.x;
            p2.x ^= p1.x;
            p1.x ^= p2.x;

            p1.y ^= p2.y;
            p2.y ^= p1.y;
            p1.y ^= p2.y;
        }
    }
}
