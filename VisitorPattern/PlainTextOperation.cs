using System;

namespace VisitorPattern
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Plain Text Heading.");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Plain Text Anchor.");
        }
    }
}
