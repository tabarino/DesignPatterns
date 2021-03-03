using System;

namespace AbstractFactoryPattern
{
    // The client code works with factories and products only
    // through abstract types: GUIFactory, Button and Checkbox.
    // This lets you pass any factory or product subclass to the client code without breaking it.
    public class Application
    {
        private readonly IGuiFactory _factory;
        private IButton _button;
        private ICheckbox _checkbox;

        public Application(IGuiFactory factory)
        {
            _factory = factory;
        }

        public void RenderButton()
        {
            _button = _factory.CreateButton();
            _button.Render();
        }

        public void RenderCheckbox()
        {
            _checkbox = _factory.CreateCheckbox();
            _checkbox.Render();
        }
    }
}
