using SatrackTeam.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Cross.Services
{
    public class ProgressDialogService : IProgressDialogService
    {
        public void Show(bool showLoader = true, string message = "")
        {
            if (showLoader)
            {
                App.Context.ShowProgressDialog(message);
            }
        }

        public void Hide()
        {
            App.Context.HideProgressDialog();
        }
    }
}
