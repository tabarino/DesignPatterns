using System;

namespace FlyweightPattern
{
    public class Point
    {
        private int _x; // 4 bytes
        private int _y; // 4 bytes
        private PointIcon _icon;

        public Point(int x, int y, PointIcon icon)
        {
            _x = x;
            _y = y;
            _icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine($"{_icon.Type} at ({_x}, {_y})");
        }
    }
}
