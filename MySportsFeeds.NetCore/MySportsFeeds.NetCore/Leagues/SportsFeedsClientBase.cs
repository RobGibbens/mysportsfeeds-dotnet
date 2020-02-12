using System;
using System.Text;

namespace MySportsFeeds.NetCore
{
    public abstract class SportsFeedsClientBase
    {
        public string AuthorizationHeader { get; }

        public SportsFeedsClientBase(string apiKey, string password)
        {
            var credentials = $"{apiKey}:{password}";
            byte[] userPassBytes = Encoding.UTF8.GetBytes(credentials);
            string userPassBase64 = Convert.ToBase64String(userPassBytes);
            AuthorizationHeader = $"Basic {userPassBase64}";
        }
    }
}