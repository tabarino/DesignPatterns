using System;

namespace MediatorPatternUsingEventsAndDelegates
{
    public class ArticlesDialogBox
    {
        private readonly ListBox _articlesListBox;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox();
            _articlesListBox.ArticlesEventHandlers += OnArticleSelected;

            _titleTextBox = new TextBox();
            _titleTextBox.ArticlesEventHandlers += OnTitleChanged;

            _saveButton = new Button();
        }

        public void SimulateUserInteraction()
        {
            _articlesListBox.Selection = "Article 1";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");

            Console.WriteLine("-------------");

            _titleTextBox.Content = "";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");

            Console.WriteLine("-------------");

            _titleTextBox.Content = "Article 2";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.IsEnabled}");
        }

        private void OnArticleSelected(object source, EventArgs args)
        {
            _titleTextBox.Content = _articlesListBox.Selection;
            _saveButton.IsEnabled = true;
        }

        private void OnTitleChanged(object source, EventArgs args)
        {
            _saveButton.IsEnabled = !String.IsNullOrEmpty(_titleTextBox.Content);
        }
    }
}
