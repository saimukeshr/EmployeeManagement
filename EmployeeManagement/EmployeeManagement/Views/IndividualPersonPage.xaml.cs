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
    public partial class IndividualPersonPage : MasterDetailPage
    {
        protected override bool OnBackButtonPressed() => true;
        public IndividualPersonPage()
        {
            InitializeComponent();
        }

        private void Attendance_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AttendancePage());
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