using Android.Gms.Ads.Initialization;

namespace TestGoogleAds.Runtime.Ads
{
    internal class MobileAdsInitializationListener
        : Java.Lang.Object, IOnInitializationCompleteListener
    {
        #region Events

        public event EventHandler<IInitializationStatus> InitializationComplete;

        #endregion

        #region Methods

        public void OnInitializationComplete(IInitializationStatus p0)
        {
            this.InitializationComplete?.Invoke(this, p0);
        }

        #endregion
    }
}
