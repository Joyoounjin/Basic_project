using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;
    public int score = 0;

    // 함수를 넣어서 실행하는 변수 
    // int 값을 매개변수로 받고 있음 
    public event Action<int> OnScoreChanged;
    void Awake()
    {
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    void PointUp()
    {
        // OnScoreChanged에 할당된 함수가 있다면 호출 
        OnScoreChanged?.Invoke(score);
        score++;
    }
}
