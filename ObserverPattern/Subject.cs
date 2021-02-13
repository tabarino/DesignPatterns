using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    // Observable
    public class Subject
    {
        private IList<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        // Push Style
        //public void NotifyObservers(int value)
        //{
        //    foreach (var observer in _observers)
        //    {
        //        observer.Update(value);
        //    }
        //}

        // Pull Style - It is more flexible, therefore is considered a better approach
        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
