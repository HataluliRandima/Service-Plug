using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMobile.Helper;
using XamarinMobile.Models;
using XamarinMobile.Services;
using XamarinMobile.Views;

namespace XamarinMobile.ViewModels
{
    public class ViewJobsStartedModel : INotifyPropertyChanged
    {
        APIServices _apiServices = new APIServices();

        public List<JobsStartedModel> _req;

        public List<ClientDetail> _clientdetails;
        public string Token { get; set; }

        public List<ClientDetail> Getclient
        {
            get { return _clientdetails; }
            set
            {
                _clientdetails = value;
                OnPropertyChanged();
            }
        }

        public List<JobsStartedModel> GetJobs
        {
            get { return _req; }
            set
            {
                _req = value;
                OnPropertyChanged();
            }
        }
        public ICommand GetJobsCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var aTok = Settings.token;
                    GetJobs = await _apiServices.GetJobsStartedAsync(aTok);
                    Debug.WriteLine(GetJobs);

                  
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
