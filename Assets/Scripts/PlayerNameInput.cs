using UnityEngine;
using UnityEngine.UI;

public class PlayerNameInput : MonoBehaviour
{
    public InputField nameInputField;

    public void OnSubmitName()
    {
        string playerName = nameInputField.text;
        DataManager.Instance.SetPlayerName(playerName);
    }
}
