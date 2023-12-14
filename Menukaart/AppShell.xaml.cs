using Menukaart.View;

namespace Menukaart
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TutorialPageView), typeof(TutorialPageView));
        }
    }
}
