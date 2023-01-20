using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Control
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrameView : ContentView
    {
        public FrameView()
        {
            InitializeComponent();
        }

        public string Text
        {
            get
            {
                return lbl.Text;
            }
            set
            {
                lbl.Text = value;
            }
        }

        public double FrameHeight
        {
            get
            {
                return frame.HeightRequest;
            }
            set
            {
                frame.HeightRequest = value;
            }
        }

        public string Icon
        {
            get
            {
                return lblIcon.Text;
            }
            set
            {
                lblIcon.Text = value;
            }
        }
    }
}