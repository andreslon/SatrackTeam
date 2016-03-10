using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using SatrackTeam.Infrastructure.Contracts;
using SatrackTeam.Cross.Services;

namespace SatrackTeam.Cross.Droid
{
    [Activity(Label = "SatrackTeam", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity, IContext
    {
        ProgressDialog progressDialog;
        protected override void OnCreate(Bundle bundle)
        {
            CreateProgressDialog();

            Xamarin.Forms.Forms.Init(this, bundle);
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            App.DependencyContainerService = new DependencyContainerService();
            base.OnCreate(bundle);
            LoadApplication(new App());
            App.Context = this;
        }

        private void CreateProgressDialog()
        {
            progressDialog = new ProgressDialog(this);
            progressDialog.Indeterminate = true;
            progressDialog.SetProgressStyle(ProgressDialogStyle.Spinner);
            progressDialog.SetMessage("Cargando, por favor espere...");
            progressDialog.SetCancelable(false);
        }


        public void HideProgressDialog()
        {
            RunOnUiThread(() =>
            {
                progressDialog.Dismiss();
            });
        }


        public void ShowProgressDialog(string message = "")
        {
            RunOnUiThread(() =>
            {
                if (string.IsNullOrEmpty(message))
                {
                    progressDialog.SetMessage("Cargando, por favor espere...");
                }
                else
                {
                    progressDialog.SetMessage(message);
                }
                progressDialog.Show();
            });
        }

      
    }
}

