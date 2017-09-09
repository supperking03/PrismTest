using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

using PrismTest.Models;

using Xamarin.Forms;

namespace PrismTest.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private ObservableCollection <Student> _students;
        private Student _selectedStudent;

        private INavigationService _navigationService;

        private string _message;

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set { SetProperty(ref _students, value); }
        }

        public Student SelectedStudent
        {
            get
            {
                return _selectedStudent;
            }
            set
            {
                SetProperty ( ref _selectedStudent, value );
            }
        }

        public ICommand NavigateCommand
        {
            get
            {
                return new Command ( NavigateToPageA );
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                SetProperty ( ref _message, value );
            }
        }

        public MainPageViewModel( INavigationService navigationService)
        {
            _students = new ObservableCollection < Student > ()
            {
                new Student (  )
                {
                    ID = "1"
                },
                new Student (  )
                {
                    ID = "2"
                }
            };

            _navigationService = navigationService;
        }

        public void NavigateToPageA ( )
        {
            var navigationParameter = new NavigationParameters
            {
                {"SelectedStudent", SelectedStudent}
            };
            _navigationService.NavigateAsync ( "PageA", navigationParameter );
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("message"))
            {
                Message = (string)parameters["message"];
            }
        }
    }
}
