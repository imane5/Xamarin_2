using Xamarin.Forms;

namespace GestionEtudiants.Droid
{
    internal class App : Application
    {
        private string fullPath;

        public App(string fullPath)
        {
            this.fullPath = fullPath;
        }
    }
}