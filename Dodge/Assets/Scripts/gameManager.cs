using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int lives;
    public bool gameActive;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public GameObject titleScreen;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        gameActive = true;
        lives = 3;
        livesText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameActive == true)
        {
            time += Time.deltaTime;
            timeText.text = "Time: " + Mathf.Round(time);
        }
        
    }
    public void ReduceLives()
    {
        lives = lives - 1;
        livesText.text = "Lives: " + lives;
        if (lives < 0)
        {
            Lose();
        }
    }
    public void Win()
    {
        gameActive = false;
        gameOverText.text = "You Win!";
        titleScreen.SetActive(true);
    }
    public void Lose()
    {
        gameActive = false;
        gameOverText.text = "GAME OVER";
        titleScreen.SetActive(true);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
