using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Infrastructure.Contracts
{
    public interface IContext
    {
        void HideProgressDialog();
        void ShowProgressDialog(string message = "");

    }
}
