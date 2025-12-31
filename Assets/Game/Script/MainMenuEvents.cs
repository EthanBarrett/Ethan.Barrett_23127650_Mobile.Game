using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuEvents : MonoBehaviour
{

    private UIDocument _document;

    private Button _button;

    private List<Button> _menuButtons = new List<Button>();

    private void Awake()
    {
        _document = GetComponent<UIDocument>();
        //play game
        _button = _document.rootVisualElement.Q("Play") as Button;
        _button.RegisterCallback<ClickEvent>(OnPlayGameClick);
        //exit game
        _button = _document.rootVisualElement.Q("Exit") as Button;
        _button.RegisterCallback<ClickEvent>(OnExitGameClick);


        _menuButtons = _document.rootVisualElement.Query<Button>().ToList();
        for (int i = 0; i < _menuButtons.Count; i++)
        {
            _menuButtons[i].RegisterCallback<ClickEvent>(OnAllButtonsClick);
        }
    }
    
    private void OnPlayGameClick(ClickEvent evt)
    {
        Debug.Log("you pressed start button");
        SceneManager.LoadScene("scene_assets");
        Time.timeScale = 1f;

    }

    private void OnExitGameClick(ClickEvent evt)
    {
        Debug.Log("you pressed exit button");
        Application.Quit();
    }



    private void OnAllButtonsClick(ClickEvent evt)
    {

    }

    private void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(OnPlayGameClick);
        _button.UnregisterCallback<ClickEvent>(OnExitGameClick);

        for (int i = 0; i < _menuButtons.Count;i++)
        {
            _menuButtons[i].UnregisterCallback<ClickEvent>(OnAllButtonsClick);
        }
    }



}
