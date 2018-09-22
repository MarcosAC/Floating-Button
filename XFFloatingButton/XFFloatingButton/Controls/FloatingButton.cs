using Xamarin.Forms;

namespace XFFloatingButton.Controls
{
    public class FloatingButton : Button
	{
		public FloatingButton ()
		{
            BackgroundColor = Color.FromHex("1E90FF");
            CornerRadius = 100;
            HeightRequest = 60;
            WidthRequest = 60;            
            FontSize = 20;
            TextColor = Color.White;
            FontAttributes = FontAttributes.Bold;
        }
	}
}