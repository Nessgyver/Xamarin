using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_TP1.models;
using Xamarin_TP1.Services;

namespace Xamarin_TP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.btn_connect.Clicked += Connection_Clicked;
        }

        public void Connection_Clicked(object sender, EventArgs e)
        {
            string id = this.id.Text;
            string password = this.password.Text;
            bool rememberMe = this.remember_me.IsToggled;
            bool isValidId = false;
            bool isValidPassword = false;

            if(id == null || id.Length<4)
            {
                this.error_id.IsVisible = true;
                this.error_id.Text = "L'identifiant doit comporter 3 caractère minimum";
            }else
            {
                this.error_id.IsVisible = false;
                isValidId = true;
            }
            if(password == null || password.Length<6)
            {
                this.error_password.IsVisible = true;
                this.error_password.Text = "Le mot de passe doit comporter 6 caractère minimum";
            }
            else
            {
                this.error_password.IsVisible = false;
                isValidPassword = true;
            }

            if(isValidId && isValidPassword)
            {
                if (DependencyService.Get<ITwitterService>().Authenticate(id, password)){
                    this.form.IsVisible = false;
                    this.tweet_feed.IsVisible = true;
                    List<TweetMsg> tweets = DependencyService.Get<ITwitterService>().GetTweets("yololo");
                    foreach (var tweet in tweets)
                    {
                        Tweet tweetBox = new Tweet();
                        tweetBox.LoadData(tweet);
                        this.tweetFeed.Children.Add(tweetBox);
                    }
                }
                else
                {
                    this.error_id.IsVisible = true;
                    this.error_id.Text = "L'identifiant et/ou le mot de passe ne correspondent pas à toto:totopwd";
                }
            }
        }
    }
}
