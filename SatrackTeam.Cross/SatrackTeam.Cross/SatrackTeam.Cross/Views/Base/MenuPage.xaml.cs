using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatrackTeam.Logic.ViewModels;
using Xamarin.Forms;

namespace SatrackTeam.Cross.Views.Base
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            lstMenu.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                ((MenuItemViewModel)e.SelectedItem).GoToMenuOptionCommand.Execute(null);
                //lstMenu.SelectedItem = null;
            };
 
        }
        protected override void OnAppearing()
        {

            base.OnAppearing();
            var main = (MainViewModel)BindingContext;
            main.PropertyChanged += main_PropertyChanged;

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            var main = (MainViewModel)BindingContext;
            main.PropertyChanged -= main_PropertyChanged;
        }

        void main_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("CloseMenu"))
            {
                ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
                if (((MainViewModel)BindingContext).SelectedMenuItem.Type == SatrackTeam.Logic.Enumerations.PagesType.Main)
                {
                    lstMenu.SelectedItem = null;
                }
            }
        }
    }
}
