using System;

namespace FacadeExercise
{
    public class OAuth
    {
        public string RequestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Get a request token.");
            return "requestToken";
        }

        public string GetAccessToken(string requestToken)
        {
            Console.WriteLine("GEt an access token.");
            return "accessToken";
        }
    }
}
