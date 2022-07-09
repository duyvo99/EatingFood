using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject goUIMenu;

    public GameObject goUIGameplay;

    public GameObject goUIGameOver;


    public DemoPhysic2D gamePlay;


    public Text txtScore_Menu;

    public Text txtScore_GamePlay;

    public Text txtScore_GameOver;

    public Text txtBestScore;

    public Text txtScore_GameOverBar;


    public List<GameObject> lsGoLive = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStart_Click()
    {
        goUIMenu.SetActive(false);

        goUIGameplay.SetActive(true);

        goUIGameOver.SetActive(false);


        gamePlay.StartGame();
    }

    public void ShowGameOver()
    {
        goUIMenu.SetActive(false);

        goUIGameplay.SetActive(false);

        goUIGameOver.SetActive(true);
    }   

    public void OnRestart_Click()
    {
        goUIMenu.SetActive(true);

        goUIGameOver.SetActive(false);

        goUIGameplay.SetActive(false);
    }    

    public void SetScore(int score)
    {
        txtScore_Menu.text = score.ToString();

        txtScore_GamePlay.text = score.ToString();

        txtScore_GameOver.text = score.ToString();

        txtScore_GameOverBar.text = score.ToString();

        int bestScore = PlayerPrefs.GetInt("BestScore");

        if(score > bestScore)
        {
            txtBestScore.text = score.ToString();

            PlayerPrefs.SetInt("BestScore", score);
        }

        else
        {
            txtBestScore.text = bestScore.ToString();
        }
    }

    public void SetLives(int lives)
    {
        for (int i = 0; i < lsGoLive.Count; i++)
        {
            if(i < lives)
            {
                lsGoLive[i].SetActive(true);
            }

            else
            {
                lsGoLive[i].SetActive(false);
            }
        }
    }
}
