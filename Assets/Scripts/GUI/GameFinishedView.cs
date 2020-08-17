using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFinishedView : MonoBehaviour 
{
    public static GameFinishedView instance;

    public Text finalText;
    public string finalTextKey;

    public GameObject finishedPanel;    

    public void Awake()
    {
        instance = this;
    }

    public void ShowWinningPanel()
    {
        Destroy(AIController.instance.gameObject);

        // aby sa predislo tomu, ze hrac naklika na dvere vela krat za sebou
        PlayerInterraction pInterraction = Camera.main.gameObject.GetComponent<PlayerInterraction>();
        if (pInterraction != null)
            pInterraction.enabled = false;

        finishedPanel.SetActive(true);
        finalText.text = Languages.instance.GetSpecificText(finalTextKey);

        Cursor.lockState = CursorLockMode.None;
    }

    public void EndButton()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
