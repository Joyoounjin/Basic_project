using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Button scoreButton;
    public int score = 0;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreButton.onClick.AddListener(RefreshUI);
    }

    void RefreshUI()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}
