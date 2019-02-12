using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisoesjoias : MonoBehaviour {

    bool isJewel = false;
    public bool addPoint = false;
    float win = 0;
    float lose = 3;

    //faz desaparecer as joias quando a boneca colide
    void OnTriggerEnter(Collider other)
    {

        //apanha e destroi a primeira joia
        if (other.name == "OldSingleCut")
        {
            Debug.Log("entrei");
            isJewel = true;
            addPoint = true;
            SetScore(10, "OldSingleCut");

            ResetJewel(other.gameObject);

        }

        //apanha e destroi todas as outras joias existentes no labirinto
        for (int i = 1; i < 41; i++)
        {
            if (other.name == "OldSingleCut" + i)
            {
                Debug.Log("entrei");
                isJewel = true;
                SetScore(10, "OldSingleCut");

                ResetJewel(other.gameObject);

            }
        }



        //colisão com joias más
        if (other.name == "RoseCut")
        {
            Debug.Log("entrei");
            isJewel = true;
            SetScore(1, "RoseCut");

            ResetJewel(other.gameObject);

        }
        for (int i = 1; i < 26; i++)
        {
            if (other.name == "RoseCut"+i)
            {
                Debug.Log("entrei");
                isJewel = true;
                SetScore(1, "RoseCut");

                ResetJewel(other.gameObject);

            }

        }
    }

    void SetScore(int score, string jewel)
    {
        Score player_score = GameObject.Find("GameStateScripts").GetComponent<Score>();

       if (jewel == "RoseCut")
        {
            player_score.TakeScore(score);
            lose = lose - score;
            //GetComponent<Animator>().Play("DAMAGED01", -1, 0f);
        }
        else if (jewel == "OldSingleCut")
        {
            Debug.Log("pontos");
            win = win + score;
            player_score.AddScore(score);
        }

        if (win == 400)
        {

            player_score.WinGame();
        }
        if (lose == 0)
        {
            player_score.LoseGame();
        }
        //parecido com o de cima mas em vez de addScore vai para WinGame
        /*else if (jewel == "OldSingleCut")//muda nome joia
        {
            player_score.WinGame(score);
        }*/
    }

    void ResetJewel(GameObject jewel)
    {
        Destroy(jewel);


    }
}
