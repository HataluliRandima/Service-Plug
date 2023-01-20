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

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingsFlyout : ContentPage
    {
        public ListView ListView;

        public RatingsFlyout()
        {
            InitializeComponent();

            BindingContext = new RatingsFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class RatingsFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<RatingsFlyoutMenuItem> MenuItems { get; set; }

            public RatingsFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<RatingsFlyoutMenuItem>(new[]
                {
                    new RatingsFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new RatingsFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new RatingsFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new RatingsFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new RatingsFlyoutMenuItem { Id = 4, Title = "Page 5" },
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