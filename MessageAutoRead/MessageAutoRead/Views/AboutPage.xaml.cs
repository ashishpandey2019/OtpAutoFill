using MessageAutoRead.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessageAutoRead.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
           
        }
     
        private async void ImageButton_OnClicked(object sender, EventArgs e)
        {
          // Navigation.PushAsync(new OtpPage());
          await  Shell.Current.GoToAsync(nameof(OtpPage));
        }
    }
}