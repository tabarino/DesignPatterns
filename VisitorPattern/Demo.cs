using System;

namespace VisitorPattern
{
    public class Demo
    {
        public static void Show()
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());
            document.Execute(new HighlightOperation());
            document.Execute(new PlainTextOperation());
        }
    }
}
