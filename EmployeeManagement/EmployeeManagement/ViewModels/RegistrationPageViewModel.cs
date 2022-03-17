using EmployeeManagement.Models;
using EmployeeManagement.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EmployeeManagement.ViewModels
{
    
     public class RegistrationPageViewModel : BaseViewModel
    {
        private Employee employeeDetail;
        public Employee EmployeeDetail
        {
            get { return employeeDetail; }
            set { employeeDetail = value; OnPropertyChanged("EmployeeDetail"); }
        }

        public Command<Employee> Signupcommand { get; set; }
        public Command BacktoSignin { get; set; }
        public RegistrationPageViewModel()
        {
            employeeDetail = new Employee();
            Signupcommand = new Command<Employee>((obj) => onSignupCommand(obj));
            BacktoSignin = new Command(() => BacktoSigninPage());
        }

        private async void BacktoSigninPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        private async void onSignupCommand(Employee emp)
        {
            try
            {
                if (emp != null)
                {
                    await App.Database.SaveEmployeeAsync(emp);
                    await App.Current.MainPage.DisplayAlert("Successfull!", "Registration Successfull", "Ok");
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                    employeeDetail = null;
                }
                else
                    await App.Current.MainPage.DisplayAlert("Alert!", "Unable to Register", "Ok");
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
