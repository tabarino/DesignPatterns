using System;

namespace ObserverExercise
{
    public class Demo
    {
        public static void Show()
        {
            var statusBar = new StatusBar();
            var stockListView = new StockListView();

            var stock1 = new Stock("Stock1", 10);
            var stock2 = new Stock("Stock2", 20);
            var stock3 = new Stock("Stock3", 30);

            // The status bar shows the popular stocks
            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);
            statusBar.Show();

            // The stock view list shows all stocks
            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);
            stockListView.AddStock(stock3);
            stockListView.Show();

            // Causes both statusBar and stockListView to get refreshed
            stock2.Price = 21;

            // Causes only the stockListView to get refreshed
            // Note: statusBar is not watching this stock
            stock3.Price = 9;
        }
    }
}
