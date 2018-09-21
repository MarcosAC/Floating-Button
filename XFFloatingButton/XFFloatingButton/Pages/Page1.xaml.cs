using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFFloatingButton.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void BtnFloatingGo_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void BtnFloatingBack_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private async void BtnFloatingDispalyAlert_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensagem", "Eu criei meu proprio floating buttom!", "Ok");
        }
    }
}