using UnityEngine;


public class AdsManager : MonoBehaviour
{
    public AdsInitializer adsInitializer;
    public BannerAds bannerAds;
    public Interstitial interstitial;

    public static AdsManager Instance { get; private set; }


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

     //   bannerAds.LoadBannerAd();
      //  interstitial.LoadInterstitalAd();


    }

    public void OnAdsInitialized()
    {

        bannerAds.LoadBannerAd();
        interstitial.LoadInterstitalAd();
    }


}
