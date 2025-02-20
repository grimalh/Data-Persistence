using UnityEngine;
using UnityEngine.Android;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string PlayerName {get; private set;}
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
        }

    public void SetPlayerName(string name)
    {
        PlayerName = name;
    }
   
}
