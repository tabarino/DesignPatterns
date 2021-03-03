using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    // It makes sense to use the Builder pattern only when your products are
    // quite complex and require extensive configuration.
    // Unlike in other creational patterns, different concrete builders can
    // produce unrelated products. In other words, results of various builders
    // may not always follow the same interface.
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            var chars = string.Empty;

            for (int i = 0; i < _parts.Count; i++)
            {
                chars += $"{_parts[i]}, ";
            }

            chars = chars.Remove(chars.Length - 2);

            return $"Product parts: {chars} \n";
        }
    }
}
