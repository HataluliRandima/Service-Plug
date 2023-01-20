using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AwaitingPage : ContentPage
    {
        public AwaitingPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             Launcher.OpenAsync(new Uri("https://www.youtube.com/watch?v=EQmPqLRgZxI"));
        }
    }
}