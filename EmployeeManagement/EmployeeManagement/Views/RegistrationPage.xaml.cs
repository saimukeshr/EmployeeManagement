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
        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = new RegistrationPageViewModel();
        }

        private void Levelpicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var Levelpicker = (Picker)sender;
            var LevelPicker = Levelpicker.Items[Levelpicker.SelectedIndex];
        }

        private void Departmentpicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Departmentpickercker = (Picker)sender;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            //Application.Current.Properties["Firstname"] = FirstName.Text;
            //Application.Current.Properties["Lastname"] = LastName.Text;
            //Application.Current.Properties["Emailid"] = emailid.Text;
            //Application.Current.Properties["ContactNo"] = ContactNo.Text;
            //Application.Current.Properties["Username"] = Username.Text;
            //Application.Current.Properties["Password"] = Password.Text;
            //Application.Current.Properties["ConfirmPassword"] = ConfirmPassword.Text;
            //Application.Current.Properties["DepartmentPicker"] = Departmentpicker;
            //Application.Current.Properties["LevelPicker"] = Levelpicker;
            //DisplayAlert("", "Registration Successful!", "OK");
            //Navigation.PopAsync();
        }

     
    }
}