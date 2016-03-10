using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Infrastructure.Contracts
{
    public interface IProgressDialogService
    {
        void Show(bool showLoader = true, string message = "");
        void Hide();
    }
}