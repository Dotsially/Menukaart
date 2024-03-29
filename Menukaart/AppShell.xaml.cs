﻿using Menukaart.View;

namespace Menukaart
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TutorialPageView), typeof(TutorialPageView));
            Routing.RegisterRoute(nameof(DatabasePageView), typeof(DatabasePageView));
            Routing.RegisterRoute(nameof(SessionInfoPageView), typeof(SessionInfoPageView));
            Routing.RegisterRoute(nameof(RouteListPageView), typeof(RouteListPageView));
            Routing.RegisterRoute(nameof(MainPageView), typeof(MainPageView));
            Routing.RegisterRoute(nameof(MapPageView), typeof(MapPageView));
        }
    }
}
