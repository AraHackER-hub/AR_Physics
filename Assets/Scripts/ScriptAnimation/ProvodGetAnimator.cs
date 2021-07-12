using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvodGetAnimator : MonoBehaviour
{

    public Animator AnimMagnit;

    void Start()
    {
        AnimMagnit = GetComponent<Animator>();
    }
    public void CallAnimator()
    {
        
        AnimMagnit.Play("animMagnit");

    }

    
}
