using Menukaart.View;

namespace Menukaart
{
    public partial class App : Application
    {
        public App(DatabasePage databasePage)
        {
            InitializeComponent();

            MainPage = databasePage;
        }
    }
}
