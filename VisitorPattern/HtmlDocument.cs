using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    public class HtmlDocument
    {
        private IList<IHtmlNode> _nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            _nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in _nodes)
            {
                node.Execute(operation);
            }
        }
    }
}
