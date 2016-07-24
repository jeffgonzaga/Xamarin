using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectWedding.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProjectWedding.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {

        private ObservableCollection<ITabPage> _tabs = new ObservableCollection<ITabPage>();
        public ObservableCollection<ITabPage> Tabs
        {
            get { return _tabs; }
            set { SetProperty(ref _tabs, value); }
        }

        public MainPageViewModel()
        {
           
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Tabs.Add(new StartPageViewModel());
            Tabs.Add(new ProfilePageViewModel());
        }
    }
}
