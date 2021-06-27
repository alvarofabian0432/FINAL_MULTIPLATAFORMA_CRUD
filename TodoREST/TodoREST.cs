using TodoREST.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TodoREST
{
	public class App : Application
	{
		public static TodoItemManager TodoManager { get; private set; }

		public App ()
		{
			TodoManager = new TodoItemManager (new RestService ());
			MainPage = new NavigationPage(new Views.TodoListPage());
		}
	}
}

