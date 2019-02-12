using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeping : MonoBehaviour {

    public int maxP1Score, maxP2Score;


    public void SetScore(int score)
    {
        string selectedPlayer = "";


                selectedPlayer = "Player1_score";

                //gravar o score mais alto
                if (maxP1Score <= score)
                {
                    maxP1Score = score;
                }

        PlayerPrefs.SetInt(selectedPlayer, score);

    }

    public void GetScore()
    {
        //verificar se já existem as chaves (corre na primeira execução)


        if (PlayerPrefs.HasKey("Player1_score"))
        {
            //se já existir, faz set do max score
            maxP1Score = PlayerPrefs.GetInt("Player1_score");
        }
        else
        {
            //se não existir, cria a entrada e faz set a 0
            PlayerPrefs.SetInt("Player1_score", 0);
        }
    }

}
