using System.ComponentModel;
using Xamarin.Forms;
using XamarinMobile.ViewModels;

namespace XamarinMobile.Views
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