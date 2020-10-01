using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_TP1.Models;

namespace Xamarin_TP1.Services
{
    public interface ITwitterService
    {
        bool Authenticate(string utilisateur, string password);
        List<TweetMsg> GetTweets(string s);
    }
}
