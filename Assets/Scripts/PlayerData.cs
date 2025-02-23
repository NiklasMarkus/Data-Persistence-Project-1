using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance;
    public string playerName; // Hier speichern wir den Namen

    public TMP_InputField nameInputField;
    public TMP_Text playerNameText;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Objekt bleibt zwischen Szenen erhalten
        }
        else
        {
            Destroy(gameObject); // Verhindert doppelte Instanzen
        }
    }

    public void StartGame()
    {
        PlayerData.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }

    void Start()
    {
        playerNameText.text = "Spieler: " + PlayerData.Instance.playerName;
    }

}
