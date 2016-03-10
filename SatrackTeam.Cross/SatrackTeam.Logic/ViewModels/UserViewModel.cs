using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SatrackTeam.Infrastructure.Contracts;
using SatrackTeam.Logic.Enumerations;
using SatrackTeam.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SatrackTeam.Logic.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        public IApiService apiService { get; set; }
        public string Id { get; set; }

        private string password;
        public string Password
        {
            get { return password; }
            set { Set(ref password, value); }
        }

        private string username;
        public string UserName
        {
            get { return username; }
            set { Set(ref username, value); }
        }
        private bool isSessionStarted;
        public bool IsSessionStarted
        {
            get { return isSessionStarted; }
            set { Set(ref isSessionStarted, value); }
        }

        public UserViewModel()
        {
            apiService = GetInstance<IApiService>();
        }
        public ICommand loginCommand
        {
            get { return new RelayCommand(Login); }
        }

        private void Login()
        {
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {

            }
            else
            {
                var response = apiService.ValidUser(ViewModelHelper.VMToModelUser(this));
                if (response.Result != null && response.Result.Count > 0)
                {
                    IsSessionStarted = true;
                    this.UserName = response.Result.FirstOrDefault().username;
                    this.Password = response.Result.FirstOrDefault().password;
                    var main = GetInstance<MainViewModel>();
                    main.NavigateTo(PagesType.Main);
                }
                
            }
        }
    }
}
