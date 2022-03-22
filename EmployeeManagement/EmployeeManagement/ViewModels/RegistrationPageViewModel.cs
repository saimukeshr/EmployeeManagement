using EmployeeManagement.Models;
using EmployeeManagement.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public Command Signupcommand { get; set; }
        public Command BacktoSignin { get; set; }
        public RegistrationPageViewModel()
        {
            employeeDetail = new Employee();
            Signupcommand = new Command(() => onSignupCommand());
            BacktoSignin = new Command(() => BacktoSigninPage());
        }

        private async void BacktoSigninPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        private async void onSignupCommand()
        {
            try
            {
                if (await IsInValid())
                    return;

                    EmployeeDetail.EmployeeID = EmployeeDetail.EmployeeID.Trim().ToLower();
                    EmployeeDetail.Password = EmployeeDetail.Password.Trim().ToLower();
                    EmployeeDetail.Department = EmployeeDetail.Department.Trim().ToLower();
                    await App.Database.SaveEmployeeAsync(EmployeeDetail);
                    await App.Current.MainPage.DisplayAlert("Successfull!", "Registration Successfull", "Ok");
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                    employeeDetail = null;
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private async Task<bool> IsInValid()
        {
            if (string.IsNullOrEmpty(EmployeeDetail.Name))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Pleae Enter Name", "Ok");
                return true;
            }
            else if (string.IsNullOrEmpty(EmployeeDetail.LastName))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Pleae Enter Last Name", "Ok");
                return true;
            }
            else if (string.IsNullOrEmpty(EmployeeDetail.EmployeeID))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Pleae Enter EmployeeID", "Ok");
                return true;
            }
            else if(await IsEmployeeIDInValid())
            {
                await App.Current.MainPage.DisplayAlert("Caution", "Invalid EmployeeID", "Ok");
                return true;
            }
            else if (string.IsNullOrEmpty(EmployeeDetail.Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Pleae Enter Password", "Ok");
                return true;
            }
            return false;
        }

        private async Task<bool> IsEmployeeIDInValid()
        {
            var output = await App.Database.GetEmployeeAsync();
            var id = output.Find(f => f.EmployeeID == EmployeeDetail.EmployeeID);
            return id == null ? false : true;
        }
    }
}
