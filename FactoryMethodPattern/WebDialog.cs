using System;

namespace FactoryMethodPattern
{
    public class WebDialog : Dialog
    {
        public override IButton CreateButton()
        {
            return new HtmlButton();
        }
    }
}
