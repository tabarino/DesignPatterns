using System;

namespace FactoryMethodPattern
{
    public class Application
    {
        private readonly string _configOS;

        public Application(string configOS)
        {
            _configOS = configOS;
        }

        public Dialog initialize()
        {
            if (_configOS == "Windows")
            {
                return new WindowsDialog();
            }
            else if (_configOS == "Web")
            {
                return new WebDialog();
            }
            
            Console.WriteLine("Error! Unknown operating system.");
            return null;
        }
    }
}
