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
    public partial class DetailedInformationPage : ContentPage
    {
        public DetailedInformationPage()
        {
            InitializeComponent();
            
            var details = App.Database.GetEmployeeAsync().ToString();
            EmployeeInfo.ItemsSource = details;
     }
        

    }
}