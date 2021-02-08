using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPattern
{
    public class BrowseHistory
    {
        private IList<string> _urls = new List<string>();

        public void Push(string url)
        {
            _urls.Add(url);
        }

        public string Pop()
        {
            var lastUrl = _urls.LastOrDefault();
            _urls.Remove(lastUrl);

            return lastUrl;
        }

        public Iterator<string> createIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : Iterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }

            public string Current()
            {
                return _history._urls[_index];
            }

            public bool HasNext()
            {
                return (_index < _history._urls.Count );
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}
