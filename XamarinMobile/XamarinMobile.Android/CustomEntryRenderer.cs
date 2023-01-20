using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content.Res;
using Android.Graphics;
using Android.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinMobile.Droid;
using CustomRenderer.Android;
using XamarinMobile.Booking;
using Android.Graphics.Drawables;
using XamarinMobile;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace CustomRenderer.Android
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                GradientDrawable gradientDrawable = new GradientDrawable();
                gradientDrawable.SetColor(global::Android.Graphics.Color.Transparent);
                Control.SetBackground(gradientDrawable);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(global::Android.Graphics.Color.PeachPuff);
            }
                
        }
    }
}