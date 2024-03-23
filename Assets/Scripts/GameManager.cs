using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
