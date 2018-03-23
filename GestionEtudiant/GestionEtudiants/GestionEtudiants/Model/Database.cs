using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace GestionEtudiants.Model
{
    public class Database
    {
        SQLite.SQLiteConnection connection;
        public Database(string path)
        {
            using (Connection = new SQLite.SQLiteConnection(path))
            {

                Connection.CreateTable<Etudiant>();
                Connection.CreateTable<Filiere>();
            };
        }

        public SQLiteConnection Connection { get => connection; set => connection = value; }
    }
}
