using System;
using System.Collections.Generic;
using System.Text;
using Xamarin_TP1.Services;
using Xamarin_TP1.models;

[assembly: Xamarin.Forms.Dependency(typeof(TwitterService))]
namespace Xamarin_TP1.Services
{
    class TwitterService : ITwitterService
    {
        string TRUE_UTILISATEUR = "toto";
        string TRUE_PWD = "totopwd";

        public bool Authenticate(string utilisateur, string password)
        {
            return (utilisateur.Equals(TRUE_UTILISATEUR) && password.Equals(TRUE_PWD));
        }

        public List<TweetMsg> GetTweets(string s)
        {
            List<TweetMsg> tweets = new List<TweetMsg>();
            for (int i = 1; i < 11; i++)
            {
                TweetMsg tweet = new TweetMsg()
                {
                    Identifiant = i,
                    DateDeCreation = new DateTime(),
                    Texte = "lorem lorem "+i+" "+s ,
                    NomUtilisateur = "User " + i,
                    IdentifiantUtilisateur = "@User"+i,
                    PseudoUtilisateur = i+"bite"
                };
                tweets.Add(tweet);
            }
            return tweets;
        }
    }
}
