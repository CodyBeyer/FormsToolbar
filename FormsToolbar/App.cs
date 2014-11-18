using System;
using Xamarin.Forms;

namespace FormsToolbar
{
	public class App
	{
		public static Page GetMainPage()
		{
			return new NavigationPage(new ToolBarPage());
		}
	}
}


