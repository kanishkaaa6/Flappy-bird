using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField]
    private GameObject gameOverPanel;
    [SerializeField]
    private Text scoreText;
    public GameObject play;
    public GameObject exit;
    public AudioSource coin;
    public AudioSource gameover;
   // public player Player;
    public void Increasescore()
    {
        coin.Play();
        score++;
        scoreText.text = score.ToString();
        //Debug.Log("hii");
    }
  
   public void GameOver()
    {
        gameover.Play();
        play.SetActive(true);
        exit.SetActive(true);
        gameOverPanel.SetActive(true);
     //   Debug.Log("game over");
    }
    public void pausegame()
    {
        Time.timeScale = 0f;
            play.SetActive(true);
        exit.SetActive(true);
    }

}
