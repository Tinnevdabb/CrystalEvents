using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CrystalEvents
{
    [Activity(Label = "Main activity", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            Button Events = FindViewById<Button>(Resource.Id.btnEvents);
            Events.Click += delegate {
                StartActivity(typeof(EventsActivity));
            };



            //Set webpages "behind" button
            Button Facebook = FindViewById<Button>(Resource.Id.btnFb);
            Facebook.Click += (object sender, EventArgs e) => {
                StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://www.facebook.com/CrystalEventsAntwerp/?fref=ts")));
            };

            Button Instagram = FindViewById<Button>(Resource.Id.btnInsta);
            Instagram.Click += (object sender, EventArgs e) => {
                StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://www.instagram.com/crystaleventsantwerp/")));
            };

            Button Youtube = FindViewById<Button>(Resource.Id.btnYt);
            Youtube.Click += (object sender, EventArgs e) => {
                StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse("https://www.youtube.com/channel/UCBIYc_rS7rK661AaPRqDhYQ")));
            };

        }
    }
}

