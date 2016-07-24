using Prism.Navigation;
using ProjectWedding.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWedding.ViewModels
{
    public class ProfilePageViewModel : ITabPage, INavigationAware
    {

        public string Title
        {
            get
            {
                return "Profile";
            }
        }

        public ProfilePageViewModel()
        {
            
        }

       

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
           
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
