using GestionEtudiants.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestionEtudiants
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            Etudiant etudiant = new Etudiant()
            {
                Cne = 1,
                Nom = "Nzesseu",
                Prenom = "Willy"
            };



            using (App.Database.Connection)
            {
                App.Database.Connection.CreateTable<Etudiant>();
                var numberOfRows = App.Database.Connection.Insert(etudiant);
                if (numberOfRows > 0)
                {
                    DisplayAlert("Success", "Etudiant correctement ajouté", "OK");
                }
                else
                {
                    DisplayAlert("Failure", "Etudiant non ajouté", "OK");
                }
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (App.Database.Connection)
            {
                App.Database.Connection.CreateTable<Etudiant>();
                var etudiants = App.Database.Connection.Table<Etudiant>().ToList();
                etudiantIListView.ItemsSource = etudiants;
            }
        }
    }
}
