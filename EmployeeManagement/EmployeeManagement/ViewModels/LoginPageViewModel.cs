using EmployeeManagement.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EmployeeManagement.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public Command LoginCommand { get; set; }
        public Command SignUpTapCommand { get; set; }
        public Command ForgotPasswordTapped { get; set; }
        public LoginPageViewModel()
        {
            LoginCommand = new Command(()=>onlogincommand());
            SignUpTapCommand = new Command(() => onSignupTapped());
            ForgotPasswordTapped = new Command(() => onForgotPasswordTapped());
        }

        private void onForgotPasswordTapped()
        {
            throw new NotImplementedException();
        }

        private async void onSignupTapped()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegistrationPage());
        }


        private async void onlogincommand()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ExecutiveLoginPage());

        }
    }
}
