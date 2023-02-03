using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class gameManager : MonoBehaviour
{

    public int lives;
    public bool gameActive;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI highScoreText;
    public Button restartButton;
    public GameObject titleScreen;
    private float time;

    private float highScore = 10000;
    public string userName = "default";
    private string HSuserName = "None";

    // Start is called before the first frame update
    void Start()
    {
        userName = sceneManager.Instance.userNameInput;
        LoadScore();
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
        if (lives == 0)
        {
            Lose();
        }
    }
    public void Win()
    {

        gameActive = false;
        gameOverText.text = "You Win!";
        titleScreen.SetActive(true);
        if (time < highScore)
        {
            highScore = Mathf.Round(time);
            HSuserName = userName;
            SaveScore();
        }
        highScoreText.text = $"Fastest: {HSuserName} at {highScore} sec";
    }
    public void Lose()
    {
        highScoreText.text = $"Fastest: {HSuserName} at {highScore} sec";
        gameActive = false;
        gameOverText.text = "GAME OVER";
        titleScreen.SetActive(true);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    [System.Serializable]
    class SaveData
    {
        public float highScore;
        public string HSuserName;
    }


    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.highScore = highScore;
        data.HSuserName = HSuserName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
            HSuserName = data.HSuserName;
        }
    }
}
