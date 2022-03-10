using EmployeeManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace EmployeeManagement.ViewModels
{

    public class LoginPageViewModel : BaseViewModel
    {
        private string entryusername;
        public string EntryUsername
        {
            get { return entryusername; }
            set { entryusername = value; OnPropertyChanged("EntryUsername"); }
        }

        private string entrypassword;
        public string Entrypassword
        {
            get { return entrypassword; }
            set { entrypassword = value; OnPropertyChanged("Entrypassword"); }
        }
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
            var output = await App.Database.GetEmployeeAsync();

            var query = output.Where(u => u.Username.Equals(entryusername) && u.Password.Equals(entrypassword));
            if (query != null)
                await App.Current.MainPage.Navigation.PushAsync(new ExecutiveLoginPage());
            else
                await App.Current.MainPage.DisplayAlert("Login Unsuccessfull", "Enter username or password", "ok");
            

        }
    }
}
