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
    public partial class RegistrationPage : ContentPage
    {
        protected override bool OnBackButtonPressed() => true;
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = new RegistrationPageViewModel();

        }

        private void Levelpicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var LevelPicker = Levelpicker.Items[Levelpicker.SelectedIndex];
        }

        private void Departmentpicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Departmentpickercker = (Picker)sender;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
           
        }

     
    }
}