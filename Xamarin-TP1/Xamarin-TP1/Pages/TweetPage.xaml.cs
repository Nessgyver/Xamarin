using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_TP1.Models;
using Xamarin_TP1.Services;
using Xamarin_TP1.Views;

namespace Xamarin_TP1
{
    public partial class TweetPage : ContentPage
    {
        private ObservableCollection<TweetMsg> tweetMsgs;
        public TweetPage()
        {
            InitializeComponent();

            tweetMsgs = new ObservableCollection<TweetMsg>();
            foreach (var tweet in DependencyService.Get<ITwitterService>().GetTweets(""))
            {
                tweetMsgs.Add(tweet);
            }

            this.tweet_feed.ItemsSource = tweetMsgs;
        }  
    }
}
