using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFPINView;

namespace Server.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerifyPin : ContentPage
    {
        public VerifyPin()
        {
            InitializeComponent();
            pinView.PINEntryCompleted += PinView_PINEntryCompleted;
        }

        private async void PinView_PINEntryCompleted(object sender, XFPINView.Helpers.PINCompletedEventArgs e)
        {
            if (pinView.PINValue != "1234")
            {
                viewText.Text = "Wrong password, please reenter!";
                pinView.PINValue = "";
            }
            else
            {
                await App._NavigationPage.PushAsync(new MainPage());
            }
        }
    }
}