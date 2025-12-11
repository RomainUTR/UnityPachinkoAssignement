using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField, Required] private TMP_Text ballLeftText;
    [SerializeField, Required] private GameObject gameOverPanel;

    private void Update()
    {
        ballLeftText.text = $"Balls Left: {Scores.ballLeft}";
    }

    public void GameOverMenu()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        Scores.isGameEnded = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        Scores.isGameEnded = false;
        Scores.ballLeft = 50;
        Scores.ballsInAction = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
