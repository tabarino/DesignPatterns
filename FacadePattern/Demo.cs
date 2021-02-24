using System;

namespace FacadePattern
{
    public class Demo
    {
        public static void Show()
        {
            var service = new NotificationService();
            service.Send("Hello World", "target");
        }
    }
}
