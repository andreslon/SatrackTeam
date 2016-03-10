using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatrackTeam.Logic.ViewModels;
using Xamarin.Forms;

namespace SatrackTeam.Cross.Views.Base
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            ((MainViewModel)this.BindingContext).Start();
        }
    }
}
