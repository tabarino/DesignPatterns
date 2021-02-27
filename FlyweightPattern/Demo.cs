using System;

namespace FlyweightPattern
{
    public class Demo
    {
        public static void Show()
        {
            var service = new PointService(new PointIconFactory());
            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
        }
    }
}
