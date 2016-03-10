using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SatrackTeam.Cross.Views;
using SatrackTeam.Infrastructure.Contracts;

namespace SatrackTeam.Cross.Services
{
    public class NavigationService : INavigationService
    {

        async public void Navigate(string viewName)
        {
            Page page;

            switch (viewName)
            {
                case "Main":
                    App.SetMainPage();
                    break;
                case "RequestPage":
                    page = new RequestPage();
                    NavigationPage.SetBackButtonTitle(page, "Atrás");
                    await App.Navigator.PushAsync(page);
                    break;
                case "Login":
                    page = new LoginPage();
                    NavigationPage.SetTitleIcon(page, "icon.png");
                    //NavigationPage.SetHasBackButton(page, false);
                    NavigationPage.SetHasNavigationBar(page, false);
                    await App.Navigator.PushAsync(page);
                    break;
                case "Close":
                    GoBack();
                    break;
            }
        }

        public async void GoBack()
        {
            await App.Navigator.PopAsync();
        }
    }
}
