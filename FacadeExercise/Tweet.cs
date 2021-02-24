using System;

namespace FacadeExercise
{
    public class Tweet
    {
        public string Message { get; private set; }

        public Tweet(string message)
        {
            Message = message;
        }
    }
}
