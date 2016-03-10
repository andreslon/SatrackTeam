using GalaSoft.MvvmLight.Command;
using SatrackTeam.Infrastructure.Contracts;
using SatrackTeam.Logic.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SatrackTeam.Logic.ViewModels
{
    public class MenuItemViewModel : ViewModelBase
    {
        IDialogService dialogService;
        INavigationService navigationService;

        public MenuItemViewModel()
        {
            dialogService = GetInstance<IDialogService>();
            navigationService = GetInstance<INavigationService>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public PagesType Type { get; set; }
        public ICommand GoToMenuOptionCommand { get { return new RelayCommand(GoToMenuOption); } }
        private void GoToMenuOption()
        {
            MainViewModel main = GetInstance<MainViewModel>();
            if (main.SelectedMenuItem == this)
                return;
            main.SelectedMenuItem = this;
            this.RaisePropertyChanged("CloseMenu");
            switch (Type)
            {
                default:
                    navigationService.Navigate(Type.ToString());
                    break;
            }
        }
    }
}
