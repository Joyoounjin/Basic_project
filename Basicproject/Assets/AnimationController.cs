using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    void Awake() // 초기화 
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable = animationVariable < 2 ? animationVariable + 1 : animationVariable - 1;
        // 0이 될때까지 빼야 됨

        if (animationVariable < 2)
        {
            animationVariable++;
        }
        else
        {
            while (animationVariable > 0)
            {
                animationVariable--;
            }
        }
        _animator.SetInteger("State", animationVariable);
    }
}
