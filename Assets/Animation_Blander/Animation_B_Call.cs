using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_B_Call : MonoBehaviour
{

    private Animator anim;



    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.Play("Ellips_Anim");
    }

    
}
