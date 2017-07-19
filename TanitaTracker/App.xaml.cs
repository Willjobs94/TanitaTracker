﻿using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Unity;
using TanitaTracker.Views;
using TanitaTracker.Views.Tabs;
using Xamarin.Forms;

namespace TanitaTracker
{
    public partial class App : PrismApplication
    {

        protected override void OnInitialized()
		{
			InitializeComponent();

			IUnityContainer _container = new UnityContainer();
			ViewModelLocationProvider.SetDefaultViewModelFactory((type) =>
				{
					return _container.Resolve(type);
				});

       //     Microsoft.Azure.Mobile.MobileCenter.Start("ios=4b5912bc-d20f-4aec-ac42-623da25fffec;" +
				   //"android=57018dad-e97a-4fd6-822a-44638269de01",
				   //typeof(Analytics), typeof(Crashes));

			NavigationService.NavigateAsync("MainTabbedPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<Views.Tabs.RegisterUserTabPage>();
			Container.RegisterTypeForNavigation<MainTabbedPage>();
			Container.RegisterTypeForNavigation<NavigationPage>();

		}


	
    }
}
