using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GestionEtudiants.Model
{
    public class OperationFiliere
    {
        private ObservableCollection<Filiere> fili;
        public OperationFiliere()
        {
            fili = new ObservableCollection<Filiere>();
        }
        public void AddFiliere(Filiere f)
        {
            using (App.Database.Connection)
            {
                Filiere f1 = new Filiere();
                f1.Id_fil = f.Id_fil;
                f1.Nom_filiere = f.Nom_filiere;
                f1.Responsbale = f.Responsbale;
                f1.Date_creation = f.Date_creation;
                App.Database.Connection.CreateTable<Filiere>();
                App.Database.Connection.Insert(f1);
                fili.Add(f1);
               
            }

        }
        public void updateFiliere(Filiere f)
        {
            using (App.Database.Connection)
            {
                Filiere f1 = new Filiere();
                f1.Id_fil = f.Id_fil;
                f1.Nom_filiere = f.Nom_filiere;
                f1.Responsbale = f.Responsbale;
                f1.Date_creation = f.Date_creation;
                App.Database.Connection.CreateTable<Filiere>();
                App.Database.Connection.Update(f1);
                fili.Add(f1);

            }

        }
    }
}


