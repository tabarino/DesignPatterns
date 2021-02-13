using System;
using CommandPattern.Editor;
using CommandPattern.Fx;

namespace CommandPattern
{
    public class Demo
    {
        public static void Show()
        {
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            button.Click();

            var compositeCommand = new CompositeCommand();
            compositeCommand.Add(new ResizeCommand());
            compositeCommand.Add(new BlackAndWhiteCommand());
            compositeCommand.Execute();

            var history = new History();
            var document = new HtmlDocument();
            document.Content = "Hello World";
            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();
            Console.WriteLine(document.Content);
            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();
            Console.WriteLine(document.Content);
        }
    }
}
