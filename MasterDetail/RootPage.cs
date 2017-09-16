using System;
using Xamarin.Forms;
using System.Linq;

namespace MasterDetail
{
	public class RootPage : MasterDetailPage
	{
		public RootPage ()
		{
            //creates a new menu page from MenuPage.cs
			var menuPage = new MenuPage ();

			menuPage.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItem);

			Master = menuPage;
            //chooses which page is selected (ContractsPage.cs)
			Detail = new NavigationPage (new ContractsPage ());
		}

		void NavigateTo (MenuItem menu)
		{
			Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);

			Detail = new NavigationPage (displayPage);

			IsPresented = false;
		}
	}
}