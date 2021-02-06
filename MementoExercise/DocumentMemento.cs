using System;

namespace MementoExercise
{
    public class DocumentMemento
    {
        private readonly string _content;
        public string Content => _content;
        private readonly string _fontName;
        public string FontName => _fontName;
        private readonly int _fontSize;
        public int FontSize => _fontSize;

        public DocumentMemento(string content, string fontName, int fontSize)
        {
            _content = content;
            _fontName = fontName;
            _fontSize = fontSize;
        }
    }
}
