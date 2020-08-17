using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsManager : MonoBehaviour 
{
    public static ControlsManager instance;

    public GameObject mobileCanvasControls;

    public MatusMouseLook mouseLook;
    public MatusPlayerMovement playerMovement;    

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        // ak je to android, vypat ovladanie na mys a klavesnicu a zapnut canvasovy joystick
        if(Application.platform == RuntimePlatform.Android)
        {
            mouseLook.enabled = playerMovement.enabled = false;
            mobileCanvasControls.SetActive(true);
        }
        else
        {
            mobileCanvasControls.SetActive(false);
            mouseLook.enabled = playerMovement.enabled = true;
        }
    }

    public void DisableControlls()
    {
        mouseLook.enabled = playerMovement.enabled = false;
        mobileCanvasControls.SetActive(false);
    }

    public void EnableControlls()
    {
        Start();
    }
}
