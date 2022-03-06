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
        
        protected override bool OnBackButtonPressed() => false;
        private EmployeeList employee;




        public ExecutiveLoginPage()
        {
           
            InitializeComponent();
            
        }

        private void Attendance_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AttendancePage());
            IsPresented = false;

        }

        private void TeamPage_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TeamsInformationPage());
            IsPresented = false;
        }

        private void Detailedinfo_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new DetailedInformationPage(employee));
            IsPresented = false;
        }
    }
}