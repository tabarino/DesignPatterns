using System;

namespace FlyweightExercise
{
    public class CellContext
    {
        // These are the attributes that can be shared by many cells.
        // That's why I've encapsulated them inside this class.
        // Our CellContextFactory class will ensure that every combination
        // of these attributes will only be stored once.
        private readonly string _fontFamily;
        private readonly int _fontSize;
        private readonly bool _isBold;

        public string FontFamily => _fontFamily;
        public int FontSize => _fontSize;
        public bool IsBold => _isBold;

        public CellContext(string fontFamily, int fontSize, bool isBold)
        {
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            _isBold = isBold;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_fontFamily, _fontSize, _isBold);
        }
    }
}
