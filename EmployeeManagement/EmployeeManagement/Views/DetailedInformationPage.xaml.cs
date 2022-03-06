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
        public DetailedInformationPage(EmployeeList employee)
        {
            if (employee == null)
             throw new ArgumentNullException();

            BindingContext = employee;
            InitializeComponent();
        }
    }
}