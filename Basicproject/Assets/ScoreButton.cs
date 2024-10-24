using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;

    // �Լ��� �־ �����ϴ� ���� 
    // int ���� �Ű������� �ް� ���� 
    public event Action<int> OnScoreChanged;
    void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    void PointUp()
    {
        // OnScoreChanged�� �Ҵ�� �Լ��� �ִٸ� ȣ�� 
        OnScoreChanged?.Invoke(score);
        score++;
    }
}
