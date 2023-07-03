using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnClick : MonoBehaviour
{
    public GameObject helpWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseHelpWindow()
    {
        helpWindow.SetActive(false);
    }
    public void OpenHelpWindow()
    {
        helpWindow.SetActive(true);
    }
    public void OpenGameScene()
    {
        SceneManager.LoadScene("Game_1A2B");
    }

    public void OpenMainScene()
    {
        SceneManager.LoadScene("Main_1A2B");
    }
}
