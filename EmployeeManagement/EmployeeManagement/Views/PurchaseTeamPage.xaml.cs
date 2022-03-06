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
    public partial class PurchaseTeamPage : ContentPage
    {
        public PurchaseTeamPage()
        {
            InitializeComponent();

            purchaseteamlist.ItemsSource = new List<EmployeeList>
            {
                new EmployeeList {Name = "Sam", Status="Manager" },
                new EmployeeList {Name ="Liam", Status="TeamMember"},
                new EmployeeList {Name ="Noah", Status="TeamMember"},
                new EmployeeList {Name ="Oliver", Status="TeamMember"},
                new EmployeeList {Name ="Elijah", Status="TeamMember"},
                new EmployeeList {Name ="William", Status="TeamMember"}
            };
        }

        private async void purchaseteamlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var employee = e.SelectedItem as EmployeeList;
            await Navigation.PushAsync(new DetailedInformationPage(employee));
            purchaseteamlist.SelectedItem = null;
        }
    }
}