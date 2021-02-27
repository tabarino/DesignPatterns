using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class PointIconFactory
    {
        private IDictionary<PointType, PointIcon> _icons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType type)
        {
            if (!_icons.ContainsKey(type))
            {
                // We should pass the icon in bytes where is the null (img/cafe.jpg)
                var icon = new PointIcon(type, null);
                _icons.Add(type, icon);
            }

            return _icons[type];
        }
    }
}
