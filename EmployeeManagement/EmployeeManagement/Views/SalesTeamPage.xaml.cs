using EmployeeManagement.Models;
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
    public partial class SalesTeamPage : ContentPage
    {
        public SalesTeamPage()
        {
            InitializeComponent();

            salesteamlist.ItemsSource = new List<Employee>
            {
                new Employee {Name = "James", Status="Manager" },
                new Employee {Name ="Benjamin", Status="TeamMember"},
                new Employee {Name ="Lucas", Status="TeamMember"},
                new Employee {Name ="Henry", Status="TeamMember"},
                new Employee {Name ="Alexander", Status="TeamMember"},
                new Employee {Name ="Harper", Status="TeamMember"}
            };
        }

        private async void salesteamlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var employee = e.SelectedItem as Employee;
            await Navigation.PushAsync(new DetailedInformationPage());
            salesteamlist.SelectedItem = null;
        }
    }
}