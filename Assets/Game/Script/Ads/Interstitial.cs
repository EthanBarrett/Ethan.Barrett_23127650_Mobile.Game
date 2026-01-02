using UnityEngine;
using UnityEngine.Advertisements;

public class Interstitial : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] private string androidAdUnitId;
    [SerializeField] private string iOSAdUnitId;

    private string adUnitId;

   

  

   private void Awake()
    {
        #if UNITY_IOS
                adUnitId = iosAdUnityId;
        #elif UNITY_ANDROID
                adUnitId = androidAdUnitId;
        #endif

    }

    public void LoadInterstitalAd()
    {
        Advertisement.Load(adUnitId, this);
    }


    public void showAd()
    {
        Advertisement.Show(adUnitId, this);
        LoadInterstitalAd();
    }



    public void OnUnityAdsAdLoaded(string placementId)
    {
        Debug.Log("Intersitial Ad Loaded");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message) { }


    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)  { }

    public void OnUnityAdsShowStart(string placementId) { }

    public void OnUnityAdsShowClick(string placementId)  { }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState) { }
}

