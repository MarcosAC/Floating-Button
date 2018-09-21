using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFFloatingButton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}

        private void BtnFloatingBack_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}