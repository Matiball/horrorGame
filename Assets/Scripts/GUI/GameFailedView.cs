using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFailedView : MonoBehaviour 
{
    public static GameFailedView instance;

    public GameObject endPanel;
    public Text textOfEndPanel;
    public GameObject button;

    public void Awake()
    {
        instance = this;
    }

    public void OpenEndPanel()
    {
        endPanel.SetActive(true);

        // ak este hrac pokracuje v hre
        if(Player.DaysRemaining > 0)
        {
            StartCoroutine(WaitForSceneReload());
        }
        else
        {
            // ak uz nezostava ziadny den, tak dovolit len navrat do hlavneho menu
            button.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public IEnumerator WaitForSceneReload()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
