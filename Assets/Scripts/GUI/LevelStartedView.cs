using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelStartedView : MonoBehaviour 
{
    public GameObject panel;
    public Text titleText;
    [Space]
    public string[] daysTextCodes;

    public void Awake()
    {
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
    }

    public void OnDisable()
    {
        SceneManager.sceneLoaded -= SceneManager_sceneLoaded;
    }

    private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        StartCoroutine(ShowLevelStartedTerm());
    }

    public IEnumerator ShowLevelStartedTerm()
    {
        panel.SetActive(true);
        Debug.Log("idcko je " + daysTextCodes[Player.DaysRemaining - 1]);
        titleText.text = Languages.instance.GetSpecificText(daysTextCodes[Player.DaysRemaining-1]);

        yield return new WaitForSeconds(5);

        panel.SetActive(false);
    }
}
