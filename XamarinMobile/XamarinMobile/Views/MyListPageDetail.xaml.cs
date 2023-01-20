using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListPageDetail : ContentPage
    {
        public MyListPageDetail(String Name, string Ingredients,string source)
        {
            InitializeComponent();

            MyItemNameShow.Text = Name;
            MyIngrediantItemShow.Text = Ingredients;
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
        }

        private void AcceptButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlyoutHome());
        }

        private void DeclineButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlyoutHome());
        }
    }
}