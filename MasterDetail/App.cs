using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class App
	{
		public static Page GetMainPage ()
		{
            //calls RootPage.cs
            return new RootPage ();
		}
	}
}