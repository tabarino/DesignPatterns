using System;

namespace ObserverExercise
{
    public class Stock
    {
        private readonly string _symbol;
        private float _price;

        public float Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPriceChanged();
            }
        }

        public Stock(string symbol, float price)
        {
            _symbol = symbol;
            Price = price;
        }

        public event EventHandler PriceChanged;

        protected virtual void OnPriceChanged()
        {
            if (PriceChanged != null)
            {
                PriceChanged(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return $"Stock - Symbol: {_symbol}, Price: {_price}.";
        }
    }
}
