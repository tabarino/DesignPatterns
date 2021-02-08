using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPatternMadeSimple
{
    public class BrowseHistory : IEnumerable
    {
        private IList<string> _urls = new List<string>();

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _urls)
            {
                yield return item;
            }
        }
        
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
    }
}
