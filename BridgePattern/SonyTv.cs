using System;

namespace BridgePattern
{
    public class SonyTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine($"Sony: Set Channel -> {number}");
        }
    }
}
