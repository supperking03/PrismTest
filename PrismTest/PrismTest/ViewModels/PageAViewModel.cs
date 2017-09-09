using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

using Prism.Navigation;

using PrismTest.Models;

namespace PrismTest.ViewModels
{
    public class PageAViewModel : BindableBase, INavigatedAware
    {
        private string _studentID;

        public string StudentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                SetProperty ( ref _studentID, value );
            }
        }
        public PageAViewModel()
        {

        }

        public void OnNavigatedFrom ( NavigationParameters parameters )
        {
            
        }

        public void OnNavigatedTo ( NavigationParameters parameters )
        {
            if ( parameters.ContainsKey ( "SelectedStudent" ) )
            {
                StudentID = ((Student)parameters["SelectedStudent"]).ID;
            }
        }
    }
}
