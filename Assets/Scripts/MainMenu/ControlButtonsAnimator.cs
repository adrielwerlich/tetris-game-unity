using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlButtonsAnimator : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("WindowPopUp", 0, 0f);
    }
}
