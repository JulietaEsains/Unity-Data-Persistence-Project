using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManager : MonoBehaviour
{
    public Text PersistentScoreText;
    public void InitializeBestScoreText()
    {
        // Sets the best score with the corresponding username
        string bestScoreUsername = PlayerPrefs.GetString("bestScoreUsername", "");
        int bestScore = PlayerPrefs.GetInt("bestScore", 0);
        PersistentScoreText.GetComponent<Text>().text = "Best Score : " + bestScoreUsername + " : " + bestScore;
    }

    private void Start()
    {
        InitializeBestScoreText();
    }
    public void StartGame()
    {
        PlayerPrefs.SetString("currentUsername", GetComponentInChildren<TextMeshProUGUI>().text);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
