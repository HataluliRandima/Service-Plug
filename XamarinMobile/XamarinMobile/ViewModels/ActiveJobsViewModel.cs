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
    public class ActiveJobsViewModel : INotifyPropertyChanged
    {
        APIServices _apiServices = new APIServices();

        public List<RequestsModel> _req;
        public string Token { get; set; }

        public List<RequestsModel> GetRequests1
        {
            get { return _req; }
            set
            {
                _req = value;
                OnPropertyChanged();
            }
        }
        public ICommand GetActiveJobsCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var aTok = Settings.token;
                    GetRequests1 = await _apiServices.GetActiveRequestsAsync(aTok);


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

