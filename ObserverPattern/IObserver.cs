using System;

namespace ObserverPattern
{
    public interface IObserver
    {
        // Push Style
        //void Update(int value);

        // Pull Style - It is more flexible, therefore is considered a better approach
        void Update();
    }
}
