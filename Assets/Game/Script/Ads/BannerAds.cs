using System;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAds : MonoBehaviour
{

    [SerializeField] private string androidAdUnitId;
    [SerializeField] private string iOSAdUnitId;

    private string adUnitId;
    private bool isLoaded;
    private bool isLoading;

    private void Awake()
    {
#if UNITY_IOS
                adUnitId = iOSAdUnitId;
#elif UNITY_ANDROID
        adUnitId = androidAdUnitId;
        #endif

       

    }

    public void LoadBannerAd()
    {
        if (isLoaded || isLoading)
            return;

        isLoaded = true;

        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);

        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = BannerLoad,
            errorCallback = BannerLoadedError
         };

        Advertisement.Banner.Load(adUnitId, options);

    }

    public void ShowBannerAd()
    {
        //  BannerOptions options = new BannerOptions
        //  {
        //      showCallback = BannerShown,
        //     clickCallback = BannerClicked,
        //      hideCallback = BannerHidden
        //   };

        isLoading = false;
        isLoaded = true;

        Advertisement.Banner.Show(adUnitId);
    }

    public void HideBannerAd()
    {
        Advertisement.Banner.Hide();
    }

    private void OnBannerLoadError(string message)
    {
        isLoading = false;
        Debug.LogError("Banner load failed: " + message);
    }

    private void BannerHidden() { }

    private void BannerClicked() { }

    private void BannerShown() { }

    private void BannerLoadedError(string message) { }

    private void BannerLoad() { }
}
