using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoExercise
{
    public class History
    {
        private IList<DocumentMemento> _mementos = new List<DocumentMemento>();

        public void Push(DocumentMemento memento)
        {
            _mementos.Add(memento);
        }

        public DocumentMemento Pop()
        {
            var lastMemento = _mementos.LastOrDefault();
            _mementos.Remove(lastMemento);

            return lastMemento;
        }
    }
}
