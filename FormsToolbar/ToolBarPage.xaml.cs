using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FormsToolbar
{	
	public partial class ToolBarPage : ContentPage
	{	
		public ToolBarPage ()
		{
			InitializeComponent ();
		}

		void OnClick(object sender, EventArgs e)
		{
			ToolbarItem tbi = (ToolbarItem) sender;
			this.DisplayAlert("Selected!", tbi.Name,"OK");
		}
	}
}

