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
    public partial class ReviewsDetail : ContentPage
    {
        public ReviewsDetail(int UserId, int JobId)
        {
            InitializeComponent();
        }
    }
}