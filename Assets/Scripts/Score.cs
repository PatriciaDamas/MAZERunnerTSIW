using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public TextMeshProUGUI score_p1;
    public TextMeshProUGUI lives_p1;

    public int currentScore_p1;
    public int currentLives;

    public bool win = false;

    public void AddScore(int scoreToAdd)
    {
        Debug.Log("entrei2");
        currentScore_p1 = currentScore_p1 + scoreToAdd;

        score_p1.SetText(currentScore_p1.ToString());
        
    }

    public void TakeScore(int scoreToTake)
    {

        currentLives = currentLives - scoreToTake;
        lives_p1.SetText(currentLives.ToString());
     
    }

   public void WinGame()
    {
        SceneManager.LoadScene("Win");
    }

    public void LoseGame()
    {
       
            SceneManager.LoadScene("Lose");
   
    }
/*
    public void MinusScore()
    {
        currentLives = currentLives - 1;

        Cha_Knight.die = true;
    }*/


    public void ResetScore()
    {
        score_p1.SetText("0");
        lives_p1.SetText("3");

        currentScore_p1 = 0;
        currentLives = 3;
    }
}
