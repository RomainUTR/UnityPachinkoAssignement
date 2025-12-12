using UnityEngine;
using Sirenix.OdinInspector;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField, Required] private string gameSceneName = "Game";
    [SerializeField, Required] private Button defaultButton;
    [SerializeField, Required] private TMP_Text titleText; // Cliquez sur le titre dans le jeu ^^'
    [SerializeField, Required] private GameObject dlcPanel;

    private int clics = 0;

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        if (defaultButton != null)
        {
            EventSystem.current.SetSelectedGameObject(defaultButton.gameObject);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        dlcPanel.SetActive(true);
    }

    public void BuyDLC()
    {
        dlcPanel.SetActive(false);
    }

    public void ClickTitle()
    {
        clics++;
        switch (clics)
        {
            case 1: titleText.text = "<u>PACHINKO_FINAL_V1</u>"; break;
            case 2: titleText.text = "<u>PACHINKO_FINAL_V2_FIX</u>"; break;
            case 3: titleText.text = "<u>PACHINKO_FINAL_V2_FIX_FINAL</u>"; break;
            case 4: titleText.text = "<u>PACHINKO_FINAL_V2_FINAL</u>"; break;
            case 5: titleText.text = "<u>PACHINKO_DONT_DELETE</u>"; break;
            case 6: titleText.text = "<u>PACHINKO_V3</u>"; break;
        }
    }
}
