﻿using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Prism.Unity;
using TanitaTracker.Views;
using Xamarin.Forms;

namespace TanitaTracker
{
    public partial class App : PrismApplication
    {

        public App()
        {

        }

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
		{
			InitializeComponent();

            Microsoft.Azure.Mobile.MobileCenter.Start("ios=4b5912bc-d20f-4aec-ac42-623da25fffec;" +
				   "android=57018dad-e97a-4fd6-822a-44638269de01",
				   typeof(Analytics), typeof(Crashes));

			NavigationService.NavigateAsync("MainTabbedPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<RegisterUserPage>();
			Container.RegisterTypeForNavigation<MainTabbedPage>();
			Container.RegisterTypeForNavigation<NavigationPage>();

		}
    }
}
