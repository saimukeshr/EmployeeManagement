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

            purchaseteamlist.ItemsSource = new List<Employee>
            {
                new Employee {Name = "Sam", Status="Manager" },
                new Employee {Name ="Liam", Status="TeamMember"},
                new Employee {Name ="Noah", Status="TeamMember"},
                new Employee {Name ="Oliver", Status="TeamMember"},
                new Employee {Name ="Elijah", Status="TeamMember"},
                new Employee {Name ="William", Status="TeamMember"}
            };
        }

        private async void purchaseteamlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var employee = e.SelectedItem as Employee;
            await Navigation.PushAsync(new DetailedInformationPage());
            purchaseteamlist.SelectedItem = null;
        }
    }
}