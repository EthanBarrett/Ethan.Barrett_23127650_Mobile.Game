using UnityEngine;
using UnityEngine.Advertisements;

public class Interstitial : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] private string androidAdUnitId;
    [SerializeField] private string iOSAdUnitId;

    private string adUnitId;

    private bool isLoaded;

  

    private void Awake()
    {
#if UNITY_IOS
                adUnitId = iOSAdUnitId;
#elif UNITY_ANDROID
        adUnitId = androidAdUnitId;
        #endif

    }

    public void LoadInterstitalAd()
    {
        if (isLoaded) return;
        Advertisement.Load(adUnitId, this);
    }


    public void showAdIntertitalAd()
    {
        if(!isLoaded)
        {
            Debug.Log("intersitital not ready");
            return;
        }
        Advertisement.Show(adUnitId, this);
        isLoaded = false;
    }



    public void OnUnityAdsAdLoaded(string placementId)
    {
        if (placementId != adUnitId) return;

        isLoaded = true;
        Debug.Log("Intersitial Ad Loaded");
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message) 
    {
        isLoaded = false;
        Debug.LogError($"Load failed: {error} - {message}");
    }


    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)  { }

    public void OnUnityAdsShowStart(string placementId) { }

    public void OnUnityAdsShowClick(string placementId)  { }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState) 
    {
        LoadInterstitalAd();
    }
}

