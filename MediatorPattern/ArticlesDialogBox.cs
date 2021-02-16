using System;

namespace MediatorPattern
{
    public class ArticlesDialogBox : DialogBox
    {
        private readonly ListBox _articlesListBox;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        public ArticlesDialogBox()
        {
            _articlesListBox = new ListBox(this);
            _titleTextBox = new TextBox(this);
            _saveButton = new Button(this);
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

        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
            {
                ArticleSelected();
            }
            else if (control == _titleTextBox)
            {
                TitleChanged();
            }
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListBox.Selection;
            _saveButton.IsEnabled = true;
        }

        private void TitleChanged()
        {
            _saveButton.IsEnabled = !String.IsNullOrEmpty(_titleTextBox.Content);
        }
    }
}
