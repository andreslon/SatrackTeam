using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatrackTeam.Logic.Enumerations;
using SatrackTeam.Infrastructure.Contracts;

namespace SatrackTeam.Logic.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigationService navigationService { get; set; }
        public UserViewModel userViewModel { get; set; }
        public ObservableCollection<RequestViewModel> listRequestViewModel { get; set; }
        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }
        public MenuItemViewModel SelectedMenuItem { get; set; }
        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set { Set(ref isBusy, value); }
        }
        public MainViewModel()
        {
            navigationService =   GetInstance<INavigationService>();
            userViewModel = new UserViewModel();
            listRequestViewModel = new ObservableCollection<RequestViewModel>();
            LoadMenuItems();
        }

        public void NavigateTo(PagesType main)
        {

        }

        private void LoadMenuItems()
        {
            MenuItems = new ObservableCollection<MenuItemViewModel>();
            MenuItems.Add(new MenuItemViewModel()
            {
                Name = "Inicio",
                Type = PagesType.Main,
                Icon = "icon.png"
            });
            SelectedMenuItem = MenuItems[0];
            MenuItems.Add(new MenuItemViewModel()
            {
                Name = "Solicitudes",
                Type = PagesType.Request,
                Icon = "icon.png"
            });

        }


        public async void Start()
        {
            navigationService.Navigate("Login");
        }
    }
}
