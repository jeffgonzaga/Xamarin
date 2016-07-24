using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectWedding.Abstract;
using ProjectWedding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectWedding.ViewModels
{
    public class StartPageViewModel :BindableBase, ITabPage,INavigationAware
    {

        public List<Tile> Tiles
        { get; set; }

        public List<Event> Events
        { get; set; }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set { SetProperty(ref _searchText, value); }
        }


        public string Title
        {
            get
            {
                return "Browse";
            }
        }

        public StartPageViewModel()
        {
            
        }

        #region INavigationAware


        public void OnNavigatedFrom(NavigationParameters parameters)
        {
           
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        #endregion

        public override string ToString()
        {
            return Title;
        }

    }
}
