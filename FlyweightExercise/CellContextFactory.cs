using System;
using System.Collections.Generic;

namespace FlyweightExercise
{
    public class CellContextFactory
    {
        private IDictionary<int, CellContext> _contexts = new Dictionary<int, CellContext>();

        public CellContext GetContext(string fontFamily, int fontSize, bool isBold)
        {
            // Generate a unique key for the combination of fontFamily, fontSize and isBold attributes.
            var hash = HashCode.Combine(fontFamily, fontSize, isBold);

            if (!_contexts.ContainsKey(hash))
            {
                _contexts.Add(hash, new CellContext(fontFamily, fontSize, isBold));
            }

            return _contexts[hash];
        }
    }
}
