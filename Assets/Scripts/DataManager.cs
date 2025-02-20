using UnityEngine;
using UnityEngine.Android;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string PlayerName {get; private set;}
    public int HighScore {get; private set;}
    public string HighScorePlayerName {get; private set;}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
            Instance = this;
            DontDestroyOnLoad(gameObject);

            LoadHighScore();
        }

    public void SetPlayerName(string name)
    {
        PlayerName = name;
    }
    public void SaveHighScore(int score){
        HighScore  = score; 
        HighScorePlayerName = PlayerName; 
        PlayerPrefs.SetInt("HighScore", HighScore);
        PlayerPrefs.SetString("HighScorePlayerName", HighScorePlayerName );
        PlayerPrefs.Save();
    }
    private void LoadHighScore()
    {
        HighScore  = PlayerPrefs.GetInt("HighScore", 0);
        HighScorePlayerName = PlayerPrefs.GetString("HighScorePlayerName", "None");
    }
   
}
