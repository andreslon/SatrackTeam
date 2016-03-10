using GalaSoft.MvvmLight;
using SatrackTeam.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Logic.ViewModels
{
    public class ViewModelBase : GalaSoft.MvvmLight.ViewModelBase
    {
        public static IDependencyContainerService Container { get; set; }

        protected T GetInstance<T>() where T : class
        {
            return Container.Resolve<T>();
        }
    }
}
