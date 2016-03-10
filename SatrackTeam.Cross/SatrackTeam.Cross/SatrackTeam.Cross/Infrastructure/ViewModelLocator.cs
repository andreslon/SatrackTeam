using SatrackTeam.Infrastructure.Contracts;
using SatrackTeam.Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Cross.Infrastructure
{
    public class ViewModelLocator
    {
        private static IDependencyContainerService _dependencyContainerService;
        public ViewModelLocator()
        {
            _dependencyContainerService = App.DependencyContainerService;
            ViewModelBase.Container = _dependencyContainerService;
        }

        public MainViewModel Main
        {
            get
            {
                return _dependencyContainerService.Resolve<MainViewModel>();
            }
        }
 
    }
}
