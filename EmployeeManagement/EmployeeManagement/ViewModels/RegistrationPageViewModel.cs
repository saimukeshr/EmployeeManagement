using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EmployeeManagement.ViewModels
{
    
     public class RegistrationPageViewModel : BaseViewModel
    {
        public Command Signupcommand { get; set; }
        
        public RegistrationPageViewModel()
        {
            Signupcommand = new Command(() => onSignupCommand());
        }

        private void onSignupCommand()
        {
            App.Current.MainPage.DisplayAlert("", "Registration Successfull", "Ok");
        }
    }
}
