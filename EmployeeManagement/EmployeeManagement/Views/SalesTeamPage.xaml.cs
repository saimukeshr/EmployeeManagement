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

            salesteamlist.ItemsSource = new List<EmployeeList>
            {
                new EmployeeList {Name = "James", Status="Manager" },
                new EmployeeList {Name ="Benjamin", Status="TeamMember"},
                new EmployeeList {Name ="Lucas", Status="TeamMember"},
                new EmployeeList {Name ="Henry", Status="TeamMember"},
                new EmployeeList {Name ="Alexander", Status="TeamMember"},
                new EmployeeList {Name ="Harper", Status="TeamMember"}
            };
        }

        private async void salesteamlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var employee = e.SelectedItem as EmployeeList;
            await Navigation.PushAsync(new DetailedInformationPage(employee));
            salesteamlist.SelectedItem = null;
        }
    }
}