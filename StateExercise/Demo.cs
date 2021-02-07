using System;

namespace StateExercise
{
    public class Demo
    {
        public static void Show()
        {
            var service = new DirectionService();
            service.TravelMode = new Bicycling();
            service.GetDirection();
            service.GetEta();

            service.TravelMode = new Driving();
            service.GetDirection();
            service.GetEta();

            service.TravelMode = new Transit();
            service.GetDirection();
            service.GetEta();

            service.TravelMode = new Walking();
            service.GetDirection();
            service.GetEta();
        }
    }
}
