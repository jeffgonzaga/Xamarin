using Prism.Unity;
using ProjectWedding.ViewModels;
using ProjectWedding.Views;
using System;

namespace ProjectWedding
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            var startPage = GetPageName<MainPageViewModel>();
            NavigationService.Navigate(startPage);
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
        }

        private string GetPageName<T>()
        {
            return typeof(T).Name.Replace("ViewModel", string.Empty);
        }
        
    }
}
