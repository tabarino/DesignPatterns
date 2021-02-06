using System;

namespace MementoExercise
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentMemento CreateMemento()
        {
            return new DocumentMemento(Content, FontName, FontSize);
        }

        public void Restore(DocumentMemento memento)
        {
            Content = memento.Content;
            FontName = memento.FontName;
            FontSize = memento.FontSize;
        }

        public override string ToString()
        {
            return $"Document - Content: {Content}, FontName: {FontName}, FontSize: {FontSize}.";
        }
    }
}
