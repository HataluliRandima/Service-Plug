using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMobile.Helper;
using XamarinMobile.Models;
using XamarinMobile.Services;

namespace XamarinMobile.ViewModels
{
    public class RequestsViewModel : INotifyPropertyChanged
    {
        APIServices _apiServices = new APIServices();

        public List<RequestsModel> _req;
        public string Token { get; set; }

        public List<RequestsModel> Requests1
        {
            get { return _req; }
            set
            {
                _req = value;
                OnPropertyChanged();
            }
        }
        public ICommand GetRequestsCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var aTok = Settings.token;
                    Requests1 = await _apiServices.GetRequestsAsync(aTok);
                });
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string
            propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
