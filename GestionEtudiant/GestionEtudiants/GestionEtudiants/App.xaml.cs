using GestionEtudiants.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GestionEtudiants
{
	public partial class App : Application
	{
        static string DB_PATH;
        static Database database;
        public static string DB_PATH1 { get => DB_PATH; set => DB_PATH = value; }
        public static Database Database { get => database; set => database = value; }

        public App ()
		{
			InitializeComponent();

			MainPage = new GestionEtudiants.MainPage();
		}
        public App(string DB_path)
        {
            InitializeComponent();
            DB_PATH = DB_path;
            Database = new Database(DB_PATH);
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
