using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
  
public class GameOver : MonoBehaviour
{
    public static GameOver Instance;

    [SerializeField] GameObject gameOverpanel;
    private void Awake()
    {
        Instance = this;
        gameOverpanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameOverScreen()
    {
        gameOverpanel.SetActive(true);
        Time.timeScale = 0f;
        
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
