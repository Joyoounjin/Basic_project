using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public ScoreButton scoreButton;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        scoreButton.OnScoreChanged += RefreshUI; // 구독
    }

    void RefreshUI(int newScore)
    {
        scoreText.text = $"Score: {newScore}";
    }

}
