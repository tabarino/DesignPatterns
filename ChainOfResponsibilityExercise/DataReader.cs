using System;

namespace ChainOfResponsibilityExercise
{
    public abstract class DataReader
    {
        private DataReader _next;

        public void SetNext(DataReader next)
        {
            _next = next;
        }

        public void Read(string filename)
        {
            if (filename.EndsWith(GetExtension())) {
                this.DoRead(filename);
                return;
            }

            if (_next != null)
            {
                _next.Read(filename);
            }
            else
            {
                // throw new Exception("File format not supported.");
                Console.WriteLine("File format not supported.");
            }
        }

        protected abstract string GetExtension();

        protected abstract void DoRead(string filename);
    }
}
