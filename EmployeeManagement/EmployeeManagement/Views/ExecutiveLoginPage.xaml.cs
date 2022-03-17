using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmployeeManagement.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExecutiveLoginPage : MasterDetailPage
    {
        
        protected override bool OnBackButtonPressed() => true;
       
        public ExecutiveLoginPage()
        {
            InitializeComponent();
            Username.Text = App.Username;
           
        }

        private void Attendance_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AttendancePage());
            IsPresented = false;
        }
      
        private void Detailedinfo_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DetailedInformationPage());
            IsPresented = false;
        }

        private async void Singut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void HomePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExecutiveLoginPage());
        }

        private void Profile_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ProfilePage());
            IsPresented = false;
        }

        private void SalesTeam_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SalesTeamPage());
            IsPresented = false;
        }

        private void PurchaseTeam_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PurchaseTeamPage());
            IsPresented = false;

        }
    }
}