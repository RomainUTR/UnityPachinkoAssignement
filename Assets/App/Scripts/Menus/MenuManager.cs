using UnityEngine;
using Sirenix.OdinInspector;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField, Required] private TMP_Text ballLeftText;

    private void Update()
    {
        ballLeftText.text = $"Balls Left: {Scores.BallLeft}";
    }
}
