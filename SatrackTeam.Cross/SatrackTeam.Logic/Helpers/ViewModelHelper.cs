using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatrackTeam.Domain.Models;
using SatrackTeam.Logic.ViewModels;

namespace SatrackTeam.Logic.Helpers
{
    public class ViewModelHelper
    {
        public static User VMToModelUser(UserViewModel userViewModel)
        {
            return new User {
                password= userViewModel.Password,
                username = userViewModel.UserName,
                id = userViewModel.Id,
            };
        }
    }
}
