using Prism.Unity;

namespace TanitaTracker
{
    public partial class App : PrismApplication
    {
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("TanitaTrackerPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<TanitaTrackerPage>();

		}
    }
}
