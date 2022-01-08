using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proiect_Xamarin.Data;
using System.IO;

namespace Proiect_Xamarin
{
    public partial class App : Application
    {
        static ProjectDatabase database;

        public static ProjectDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProjectDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProjectDatabase.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LogInPage());
           // MainPage = new NavigationPage(new MyRoutesPage());
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
