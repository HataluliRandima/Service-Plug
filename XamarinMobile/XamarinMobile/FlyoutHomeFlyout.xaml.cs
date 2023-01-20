using Android.Graphics.Fonts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Views;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutHomeFlyout : ContentPage
    {
        public ListView ListView;

        public FlyoutHomeFlyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutHomeFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class FlyoutHomeFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutHomeFlyoutMenuItem> MenuItems { get; set; }

            public FlyoutHomeFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutHomeFlyoutMenuItem>(new[]
                {
                    new FlyoutHomeFlyoutMenuItem { Id = 0, Title = "Home Dashboard" ,IconSource="Home.png", TargetType=typeof(FlyoutHomeDetail)},
                    new FlyoutHomeFlyoutMenuItem { Id = 1, Title = "View Booking Requests" ,IconSource="ViewBooking1.png", TargetType=typeof(Requests)},
                    new FlyoutHomeFlyoutMenuItem { Id = 2, Title = "Profile",IconSource="profile1.png", TargetType=typeof(Profile)},
                    new FlyoutHomeFlyoutMenuItem { Id = 3, Title = "Scheduling",IconSource="calendar.jfif", TargetType=typeof(Scheduling2)},
                    new FlyoutHomeFlyoutMenuItem { Id = 4, Title = "Reports",IconSource="reportsicon3.png", TargetType=typeof(Reports)},           
                    new FlyoutHomeFlyoutMenuItem { Id = 5, Title = "Verification",IconSource="VerificationIcon.png", TargetType=typeof(PDFUpload)},
                    new FlyoutHomeFlyoutMenuItem { Id = 6, Title = "Reviews",IconSource="Reviews.png", TargetType=typeof(Reviews)},
                    new FlyoutHomeFlyoutMenuItem { Id = 7, Title = "Log Out",IconSource="Logout2.png", TargetType=typeof(LoginPage) },
                });
            }
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}