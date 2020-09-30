using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_TP1.models;

namespace Xamarin_TP1.Services
{
    public interface ITwitterService
    {
        bool Authenticate(string utilisateur, string password);
        List<TweetMsg> GetTweets(string s);
    }
}
