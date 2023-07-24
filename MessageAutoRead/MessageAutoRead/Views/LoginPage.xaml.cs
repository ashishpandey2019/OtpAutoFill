using MessageAutoRead.Services;
using MessageAutoRead.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessageAutoRead.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.Subscribe<string>(Events.SmsRecieved, code =>
            {
                smSEntry.Text = code;
                _stopTimer = true;
            });
        }
        private bool _stopTimer;
        private TimeSpan _waitSpan;
        private void ImageButton_OnClicked(object sender, EventArgs e)
        {
            try
            {
                CommonServices.ListenToSmsRetriever();
                // View 
                _waitSpan = new TimeSpan(0, 5, 0);
                TimerLabel.TextColor = Color.Black;
                _stopTimer = false;
                Device.StartTimer(new TimeSpan(0, 0, 1), () =>
                {
                    if (_waitSpan.TotalSeconds == 0.0)
                        TimerLabel.TextColor = Color.Red;
                    TimerLabel.Text = _stopTimer ? "" : _waitSpan.ToString(@"mm\:ss");
                    _waitSpan = _waitSpan.Subtract(new TimeSpan(0, 0, 1));

                    return _waitSpan.TotalSeconds >= 0 && !_stopTimer;
                });
            }
            catch (Exception ee)
            {

            }
        }
    }
}