﻿using EmployeeManagement.Localdb;
using EmployeeManagement.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmployeeManagement
{
    public partial class App : Application
    {
        static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Employee.db3"));
                }
                return database;
            }
        }

        public static string Username;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

           
        }

        
            
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
