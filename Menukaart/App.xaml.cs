using Menukaart.View;

namespace Menukaart
{
    public partial class App : Application
    {
        public App(DatabasePageView databasePage)
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
