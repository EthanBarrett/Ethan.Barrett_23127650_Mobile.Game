using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int gamePlayed = 1;

  //  private bool isGameOver;

    private void Awake()
    {
        StartCoroutine(DisplayBannerWithDely());
        AdsManager.Instance.bannerAds.HideBannerAd();
        
    }

    private IEnumerator DisplayBannerWithDely()
    {
        yield return new WaitForSeconds(1f);
        AdsManager.Instance.bannerAds.ShowBannerAd();
    }

   
}
