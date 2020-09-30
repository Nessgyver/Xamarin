using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_TP1.models;

namespace Xamarin_TP1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tweet : ContentView
    {
        public Tweet()
        {
            InitializeComponent();
        }

        internal void LoadData(TweetMsg tweet)
        {
            this.identifiantUtilisateur.Text = tweet.IdentifiantUtilisateur;
            this.dateDeCreation.Text = tweet.DateDeCreation.ToString();
            this.texte.Text = tweet.Texte;
            this.pseudoUtilisateur.Text = tweet.PseudoUtilisateur;
        }
    }
}