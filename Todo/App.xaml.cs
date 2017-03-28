using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Todo
{
	public partial class App : Application
	{
		static ITodoItemRepository todoItemRepository;

		public static ITodoItemRepository TodoManager
		{
			get
			{
				if (todoItemRepository == null)
				{
					todoItemRepository = new TodoItemRepository(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
				}
				return todoItemRepository;
			}
		}

		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new TodoListPage());
		}

		protected override void OnStart()
		{
			var mobileCenterKey = $"ios={Constants.MobileCenterIOsKey};android={Constants.MobileCenterAndroidKey}";
			MobileCenter.Start(mobileCenterKey,
				   typeof(Analytics), typeof(Crashes));
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
