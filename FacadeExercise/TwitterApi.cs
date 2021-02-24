using System;
using System.Collections.Generic;

namespace FacadeExercise
{
    public class TwitterApi
    {
        private readonly string _appKey;
        private readonly string _secret;

        public TwitterApi(string appKey, string secret)
        {
            _appKey = appKey;
            _secret = secret;
        }

        public IList<Tweet> GetRecentTweets()
        {
            var twitterClient = new TwitterClient();
            var tweets = twitterClient.GetRecentTweets(GetAccessToken());

            return tweets;
        }

        private string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken("appKey", "secret");
            var accessToken = oauth.GetAccessToken(requestToken);

            return accessToken;
        }
    }
}
