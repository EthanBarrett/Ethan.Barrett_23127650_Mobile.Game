using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(DisplayBannerWithDely());
    }

    private IEnumerator DisplayBannerWithDely()
    {
        yield return new WaitForSeconds(1f);
        AdsManager.Instance.bannerAds.ShowBannerAd();
    }

    private void Update()
    {
      // AdsManager.Instance.bannerAds.HideBannerAd();
       
    }
}
