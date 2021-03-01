using System;

namespace FactoryMethodPattern
{
    public abstract class Dialog
    {
        public abstract IButton CreateButton();

        public void RenderWindow()
        {
            var okButton = CreateButton();
            okButton.Render();
            okButton.OnClick();
        }
    }
}
