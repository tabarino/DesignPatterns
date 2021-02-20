using System;

namespace VisitorPattern
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
