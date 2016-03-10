using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrackTeam.Logic.ViewModels
{
    public class RequestViewModel : ViewModelBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { Set(ref name, value); }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { Set(ref email, value); }
        }
        private string description;
        public string Descripcion
        {
            get { return description; }
            set { Set(ref description, value); }
        }
        private int priority;
        public int Priority
        {
            get { return priority; }
            set { Set(ref priority, value); }
        }
        private bool @checked;
        public bool @Checked
        {
            get { return @checked; }
            set { Set(ref @checked, value); }
        }


    }
}
