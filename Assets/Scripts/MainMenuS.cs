using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuS : MonoBehaviour {
    public GameObject CanvasObject;

    public void PlayGame()
    {
       // Debug.Log("UUU");
        SceneManager.LoadScene("Level 01");
        CanvasObject.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void BackMenu()
    {
        /*GetComponent<Score>().ResetScore();
        GetComponent<Trigger>().ResetPlayer();*/
        SceneManager.LoadScene("Begining");
    }

}
