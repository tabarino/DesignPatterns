using System;

namespace FacadeExercise
{
    public class Demo
    {
        public static void Show()
        {
            var twitterApi = new TwitterApi("appKey", "secret");
            var tweets = twitterApi.GetRecentTweets();

            foreach (var tweet in tweets)
            {
                Console.WriteLine(tweet.Message);
            }
        }
    }
}
