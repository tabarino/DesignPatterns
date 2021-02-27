using System;

namespace BridgePattern
{
    public class Demo
    {
        public static void Show()
        {
            var sonyRemoteControl = new AdvancedRemoteControl(new SonyTv());
            sonyRemoteControl.TurnOn();
            sonyRemoteControl.SetChannel(4);
            sonyRemoteControl.TurnOff();

            var samsungRemoteControl = new AdvancedRemoteControl(new SamsungTv());
            samsungRemoteControl.TurnOn();
            samsungRemoteControl.SetChannel(4);
            samsungRemoteControl.TurnOff();
        }
    }
}
