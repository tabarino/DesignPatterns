using System;

namespace BridgePattern
{
    public class SamsungTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Samsung: Turn On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: Turn Off");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"Samsung: Set Channel -> {number}");
        }
    }
}
