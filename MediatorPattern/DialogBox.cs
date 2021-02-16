using System;

namespace MediatorPattern
{
    // In this case it could be an interface
    // However in a real world it is better to be a abstract class
    // Because we will implement some common behavior between the other classes
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }
}
