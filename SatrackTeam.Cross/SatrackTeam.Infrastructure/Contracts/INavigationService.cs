using System.Threading.Tasks;
namespace SatrackTeam.Infrastructure.Contracts
{   
    public interface INavigationService
    {
        void Navigate(string viewName);
        void GoBack();
    }
}
