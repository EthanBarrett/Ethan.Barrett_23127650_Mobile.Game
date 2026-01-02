using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
 
    
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject GamePlay;

    void Start()
    {
        pauseMenu.SetActive(false);
    }


    public void Pause()
    {
        pauseMenu.SetActive(true);
        GamePlay.SetActive(false);
        Time.timeScale = 0f;
        AdsManager.Instance.bannerAds.ShowBannerAd();
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        GamePlay.SetActive(true);
        Time.timeScale = 1f;
        AdsManager.Instance.bannerAds.HideBannerAd();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");

    }

    public void Quit()
    {
       
        Application.Quit();

    }
}
