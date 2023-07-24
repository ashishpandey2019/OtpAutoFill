using MessageAutoRead.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MessageAutoRead.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}