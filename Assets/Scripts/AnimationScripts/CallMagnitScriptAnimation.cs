using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMagnitScriptAnimation : MonoBehaviour
{
    public Animator CallAnimator;
    

    void Start()
    {
        CallAnimator = gameObject.GetComponent<Animator>();
        CallAnimator.Play("Default Take");
    }

    
}
