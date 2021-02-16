using System;

namespace MediatorPatternUsingObservers
{
    public class ArticlesDialogBox
    {
        private readonly ListBox _articlesListBox;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox();
            _articlesListBox.AddEventHandler(new ArticleSelected(this));

            _titleTextBox = new TextBox();
            _titleTextBox.AddEventHandler(new TitleChanged(this));

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

        private class ArticleSelected : IEventHandler
        {
            private readonly ArticlesDialogBox _dialogBox;

            public ArticleSelected(ArticlesDialogBox dialogBox)
            {
                _dialogBox = dialogBox;
            }

            public void Handle()
            {
                _dialogBox._titleTextBox.Content = _dialogBox._articlesListBox.Selection;
                _dialogBox._saveButton.IsEnabled = true;
            }
        }

        private class TitleChanged : IEventHandler
        {
            private readonly ArticlesDialogBox _dialogBox;

            public TitleChanged(ArticlesDialogBox dialogBox)
            {
                _dialogBox = dialogBox;
            }

            public void Handle()
            {
                _dialogBox._saveButton.IsEnabled = !String.IsNullOrEmpty(_dialogBox._titleTextBox.Content);
            }
        }
    }
}
