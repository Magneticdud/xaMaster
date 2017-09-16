using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{

	public class MenuListView : ListView
	{
		public MenuListView ()
		{
            //gets list data from MenuListData.cs
			List<MenuItem> data = new MenuListData ();

			ItemsSource = data;
			VerticalOptions = LayoutOptions.FillAndExpand;
			BackgroundColor = Color.Transparent;

			var cell = new DataTemplate (typeof(ImageCell));
			cell.SetBinding (TextCell.TextProperty, "Title");
			cell.SetBinding (ImageCell.ImageSourceProperty, "IconSource");

			ItemTemplate = cell;
            //which one is selected, for example the first one
			SelectedItem = data [0];
		}
	}
	
}