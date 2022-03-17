using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmployeeManagement.ViewModels
{
    public class AttendancePageViewModel : BaseViewModel
    {
        private string startTime;
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; OnPropertyChanged("StartTime"); }
        }

        private string endTime;
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; OnPropertyChanged("EndTime"); }
        }
        public Command AttendanceSubmit { get; set; }

        public AttendancePageViewModel(string EntryUsername)
        {
            AttendanceSubmit = new Command(() => SubmitCommand());
        }

        public AttendancePageViewModel()
        {
            AttendanceSubmit = new Command(() => SubmitCommand());
        }
        //public Task<Employee> GetEmployeeAsync(string Username)
        //{
            
        //    //return App.Database.GetEmployeeAsync().Where(u => u.US == Username).FirstOrDefaultAsync();
        //}
        private void SubmitCommand()
        {
            try
            {
                

              
                
                App.Current.MainPage.DisplayAlert("", "Data Saved Successfully", "Ok");
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            
        }
    }
}
