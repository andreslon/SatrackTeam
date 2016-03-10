using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatrackTeam.Logic.Enumerations;

namespace SatrackTeam.Logic.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public UserViewModel userViewModel { get; set; }
        public ObservableCollection<RequestViewModel> listRequestViewModel { get; set; }

        public MainViewModel()
        {
            userViewModel = new UserViewModel();
            listRequestViewModel = new ObservableCollection<RequestViewModel>();
        }

        public void NavigateTo(PagesType main)
        {
           
        }
    }
}
