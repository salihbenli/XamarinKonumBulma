using System;
using System.IO;
using LocalDatabaseTutorial;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
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
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }

        public static string FilePath { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new iletisim());
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
