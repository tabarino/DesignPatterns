using System;

namespace VisitorPattern
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Highlight Heading.");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlight Anchor.");
        }
    }
}
