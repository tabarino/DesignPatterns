using System;

namespace CommandPattern.Fx
{
    public class Button
    {
        private readonly ICommand _command;
        public string Label { get; set; }

        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            _command.Execute();
        }
    }
}
