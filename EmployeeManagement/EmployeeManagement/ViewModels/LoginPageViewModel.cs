using EmployeeManagement.Models;
using EmployeeManagement.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace EmployeeManagement.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {        
        public List<string> Departments { get; set; }
        public LoginPageViewModel()
        {
            Departments = new List<string>
            {
                "Executive", "Purchase Team", "Sales Team"

            };

            LoginCommand = new Command(() => onlogincommand());
            SignUpTapCommand = new Command(() => onSignupTapped());
            ForgotPasswordTapped = new Command(() => onForgotPasswordTapped());
        }
       

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

        private string selecteddepartment;
        public string Selecteddepartment
        {
            get { return selecteddepartment; }
            set { selecteddepartment = value; OnPropertyChanged("Selecteddepartment"); }
            
        }
        public List<string> ItemsList { get; set; }
        public Command LoginCommand { get; set; }
        public Command SignUpTapCommand { get; set; }
        public Command ForgotPasswordTapped { get; set; }
        

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
            try
            {
                if (string.IsNullOrEmpty(EntryUsername) || string.IsNullOrEmpty(Entrypassword))
                    await App.Current.MainPage.DisplayAlert("Error", "Pleae Enter username or password", "Ok");
                else
                {
                    var output = await App.Database.GetEmployeeAsync();
                    var query = output.Where(u => u.Username == EntryUsername && u.Password==Entrypassword).FirstOrDefault();
                    if (query != null && Selecteddepartment == "ExecutiveTeam")
                    {
                        App.Username = query.Username;
                        await App.Current.MainPage.Navigation.PushAsync(new ExecutiveLoginPage());
                        
                    }
                    else if(query != null && Selecteddepartment == "Purchase Team")
                    {
                        App.Username = query.Username;
                        await App.Current.MainPage.Navigation.PushAsync(new PurchaseTeamLoginPage());
                    }
                    else if (query != null && Selecteddepartment == "Sales Team")
                    {
                        App.Username = query.Username;
                        await App.Current.MainPage.Navigation.PushAsync(new SalesTeamLoginPage());
                    }
                    else
                        await App.Current.MainPage.DisplayAlert("Invalid Details", "Login Unsuccessfull ", "Ok");
                }
            }
            catch(Exception ex)
            {
               ex.ToString();
            }
            
            

        }
    }
}
