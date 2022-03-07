using EmployeeManagement.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EmployeeManagement.ViewModels
{
   public  class TeamInformationPageViewModel
    {
        public Command PurchaseteamCommand { get; set; }
        public Command SalesteamCommand { get; set; }

        public TeamInformationPageViewModel()
        {
            PurchaseteamCommand = new Command(() => onpurchasepagecommand());
            SalesteamCommand = new Command(() => onsalespagecommand());
        }

        private async void onsalespagecommand()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SalesTeamPage());
        }

        private async void onpurchasepagecommand()
        {
            await App.Current.MainPage.Navigation.PushAsync(new PurchaseTeamPage());
        }
    }
}
