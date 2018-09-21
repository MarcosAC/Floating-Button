using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFFloatingButton
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnFloating_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Page1());
        }
    }
}
