using SatrackTeam.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Cross.Services
{
    public class DialogService : IDialogService
    {
        public async Task ShowMessage(string message, string title)
        {
            await App.Navigator.DisplayAlert(title, message, "Aceptar");
        }
    }
}
