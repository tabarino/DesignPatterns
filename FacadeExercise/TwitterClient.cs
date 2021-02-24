using System;
using System.Collections.Generic;

namespace FacadeExercise
{
    public class TwitterClient
    {
        public IList<Tweet> GetRecentTweets(string accessToken)
        {
            Console.WriteLine("Getting recent tweets.");
            return new List<Tweet>()
            {
                new Tweet("Tweet1"),
                new Tweet("Tweet2"),
                new Tweet("Tweet3")
            };
        }
    }
}
