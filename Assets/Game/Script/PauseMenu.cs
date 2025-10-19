using UnityEngine;

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
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        GamePlay.SetActive(true);
        Time.timeScale = 1f;

    }

    public void Menu()
    {


    }

    public void Quit()
    {


    }
}
