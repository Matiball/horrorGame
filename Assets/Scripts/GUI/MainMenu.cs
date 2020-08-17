using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour 
{
    public Text startButtonText, exitButtonText;
    public string startTextKey, exitTextKey;

    public void Start()
    {
        startButtonText.text = Languages.instance.GetSpecificText(startTextKey);
        exitButtonText.text = Languages.instance.GetSpecificText(exitTextKey);
    }

    public void ChangeLanguageToCZ()
    {
        Languages.instance.LoadLanguage("cs");
        Start();
    }

    public void ChangeLanguageToEN()
    {
        Languages.instance.LoadLanguage("en");
        Start();
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene("House");
    }
}
