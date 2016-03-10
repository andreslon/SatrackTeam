using Xamarin.Forms;

namespace SatrackTeam.Cross.Selectors
{
    public class DataTemplateSelector
    {
        public virtual DataTemplate SelectTemplate(object item, BindableObject container)
        {
            return null;
        }
    }
}