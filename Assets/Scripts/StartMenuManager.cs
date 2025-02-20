
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
    public InputField playerNameInputField;

    public void OnStartButtonClicked()
    {
        string playerName = playerNameInputField.text;
        DataManager.Instance.SetPlayerName(playerName);
        SceneManager.LoadScene("main"); // Replace with the actual name of your main game scene
    }
}