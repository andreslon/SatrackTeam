using System;
using System.Threading.Tasks;

namespace SatrackTeam.Infrastructure.Contracts
{
    public interface IDialogService
    {
        Task ShowMessage(string message, string title);
    }
}
