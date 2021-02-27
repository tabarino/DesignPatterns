using System;

namespace FlyweightPattern
{
    public class PointIcon
    {
        private readonly PointType _type; // 4 bytes
        private readonly byte[] _icon; // 20 KB

        public PointType Type => _type;

        public PointIcon(PointType type, byte[] icon)
        {
            _type = type;
            _icon = icon;
        }
    }
}
