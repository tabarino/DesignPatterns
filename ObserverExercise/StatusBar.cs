using System;
using System.Collections.Generic;

namespace ObserverExercise
{
    public class StatusBar
    {
        private IList<Stock> _stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.PriceChanged += OnPriceChanged;
        }

        public void Show()
        {
            Console.WriteLine("Status Bar");
            foreach (var stock in _stocks)
            {
                Console.WriteLine(stock.ToString());
            }
        }

        public void OnPriceChanged(object source, EventArgs args)
        {
            Console.WriteLine("Price Changed - Refreshing Status Bar");
            Show();
        }
    }
}
