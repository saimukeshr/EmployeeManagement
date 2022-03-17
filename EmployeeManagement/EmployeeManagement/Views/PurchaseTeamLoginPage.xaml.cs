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
    public partial class PurchaseTeamLoginPage : MasterDetailPage
    {
        protected override bool OnBackButtonPressed() => true;
        public PurchaseTeamLoginPage()
        {
            InitializeComponent();
        }

        private async void HomePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SalesTeamLoginPage());
        }

        private void Attendance_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AttendancePage());
            IsPresented = false;
        }

        private void PurchaseTeam_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PurchaseTeamPage());
            IsPresented = false;
        }

        private void Detailedinfo_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DetailedInformationPage());
            IsPresented = false;
        }

        private void Profile_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ProfilePage());
            IsPresented = false;
        }

        private async void Singut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}