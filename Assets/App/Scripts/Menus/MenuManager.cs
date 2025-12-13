using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField, Required] private TMP_Text ballLeftText;
    [SerializeField, Required] private TMP_Text ballInActionText;
    [SerializeField, Required] private TMP_Text gameOverText;
    [SerializeField, Required] private GameObject gameOverPanel;

    private void Update()
    {
        ballLeftText.text = $"Balls Left: {Scores.ballLeft}";
        ballInActionText.text = $"Balls in action: {Scores.ballsInAction}";
    }

    public void GameOverMenu()
    {
        gameOverPanel.SetActive(true);
        gameOverText.text = "You end the game ! You have " + (Scores.ballLeft + Scores.ballsInAction) + " ball(s) left.";
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
