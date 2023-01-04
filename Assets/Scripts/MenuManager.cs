using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI soundText;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.isMute)
            soundText.text = "/";
        else
            soundText.text = "";
    }

    public void ToggleMute()
    {
        if (GameManager.isMute)
        {
            GameManager.isMute = false;
            soundText.text = "";
        }
        else
        {
            GameManager.isMute = true;
            soundText.text = "/";
        }
    }

   public void QuitGame()
    {
        Application.Quit();
    }
}
