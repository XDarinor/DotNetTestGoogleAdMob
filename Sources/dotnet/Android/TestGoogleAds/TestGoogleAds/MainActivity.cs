using Android.Gms.Ads.Initialization;
using Android.Gms.Ads;
using Java.Lang;
using TestGoogleAds.Runtime.Ads;
using AndroidX.AppCompat.App;

namespace TestGoogleAds
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        #region Fields

        private readonly MobileAdsInitializationListener mobileAdsInitializationListener = new MobileAdsInitializationListener();
        private AdView? adView;

        #endregion

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            this.mobileAdsInitializationListener.InitializationComplete += MobileAdsInitializationListener_InitializationComplete;
            MobileAds.Initialize(this, this.mobileAdsInitializationListener);

            this.adView = this.FindViewById<AdView>(Resource.Id.adView);
            AdRequest adRequest = new AdRequest.Builder().Build();
            this.adView?.LoadAd(adRequest);
        }

        #region Event handlers

        private void MobileAdsInitializationListener_InitializationComplete(object? sender, IInitializationStatus e)
        {
        }

        #endregion
    }
}