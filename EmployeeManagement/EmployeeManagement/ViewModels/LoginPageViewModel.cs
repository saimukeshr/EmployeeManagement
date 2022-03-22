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
       
       

        private string employeeID;
        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; OnPropertyChanged("EmployeeID"); }
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

        public LoginPageViewModel()
        {
            Departments = new List<string>
            {
                "ExecutiveTeam", "PurchaseTeam", "SalesTeam", "TeamMember"

            };

            LoginCommand = new Command(() => onlogincommand());
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
            try
            {
                if (string.IsNullOrEmpty(EmployeeID) || string.IsNullOrEmpty(Entrypassword))
                    await App.Current.MainPage.DisplayAlert("Error", "Pleae Enter username or password", "Ok");
                else
                {
                    var output = await App.Database.GetEmployeeAsync();
                    var query = output.Where(u => u.EmployeeID == EmployeeID.Trim().ToLower() && u.Password==Entrypassword.Trim().ToLower() && u.Department==Selecteddepartment.Trim().ToLower()).SingleOrDefault();

                    if(query != null)
                    {
                        App.Username = query.Name + " " + query.LastName;
                        switch (Selecteddepartment)
                        {
                            case "ExecutiveTeam":
                                await App.Current.MainPage.Navigation.PushAsync(new ExecutiveLoginPage());
                                break;
                            case "SalesTeam":
                                await App.Current.MainPage.Navigation.PushAsync(new SalesTeamLoginPage());
                                break;
                            case "PurchaseTeam":
                                await App.Current.MainPage.Navigation.PushAsync(new PurchaseTeamLoginPage());
                                break;
                            case "TeamMember":
                                await App.Current.MainPage.Navigation.PushAsync(new IndividualPersonPage());
                                break;
                            default:
                                break;
                        }
                    }
                    else
                         await App.Current.MainPage.DisplayAlert("Invalid Details", "Login Unsuccessfull ", "Ok");


                    //if (query != null && Selecteddepartment == "ExecutiveTeam")
                    //{

                        //    App.Username = query.EmployeeID;
                        //    await App.Current.MainPage.Navigation.PushAsync(new ExecutiveLoginPage());

                        //}
                        //else if(query != null && Selecteddepartment == "PurchaseTeam")
                        //{
                        //    App.Username = query.EmployeeID;
                        //    await App.Current.MainPage.Navigation.PushAsync(new PurchaseTeamLoginPage());
                        //}
                        //else if (query != null && Selecteddepartment == "SalesTeam")
                        //{
                        //    App.Username = query.EmployeeID;
                        //    await App.Current.MainPage.Navigation.PushAsync(new SalesTeamLoginPage());
                        //}
                        //else if (query != null && Selecteddepartment == "TeamMember")
                        //{
                        //    App.Username = query.EmployeeID;
                        //    await App.Current.MainPage.Navigation.PushAsync(new IndividualPersonPage());
                        //}
                        //else
                        //    await App.Current.MainPage.DisplayAlert("Invalid Details", "Login Unsuccessfull ", "Ok");
                }
            }
            catch(Exception ex)
            {
               ex.ToString();
            }
            
            

        }
    }
}
