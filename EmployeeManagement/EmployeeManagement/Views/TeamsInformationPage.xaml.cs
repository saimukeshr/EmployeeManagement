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
    public partial class TeamsInformationPage : ContentPage
    {
        public TeamsInformationPage()
        {
            InitializeComponent();
            BindingContext = new TeamInformationPageViewModel();
        }

        
    }
}