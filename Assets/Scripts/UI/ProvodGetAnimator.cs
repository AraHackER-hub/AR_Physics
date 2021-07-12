using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParcticalSystemStart : MonoBehaviour
{
    [SerializeField] private GameObject ProvodObject;
    private Color _colorMagnitinSystem;


    private Animator AnimMagnit;

    void Start()
    {
        AnimMagnit = GetComponent<Animator>();
        
    }

    /// <summary>
    /// Поменять функцию CallAnimator
    /// на сопрограмму
    /// </summary>



    //IEnumerator DelayinUnityScene()
    //{
    //    yield return new WaitForSeconds(5f);
    //}
    //IEnumerator AlphaParamChangeCall()
    //{
    //    for (float alphaParam = 1f; alphaParam != .5f; alphaParam -= .1f)
    //    {
    //        _colorMagnitinSystem = ProvodObject.GetComponent<Renderer>().material.color;
    //        _colorMagnitinSystem.a = alphaParam;

    //        ProvodObject.GetComponent<Renderer>().material.color = _colorMagnitinSystem;


    //        yield return null;
    //    }
    //}

    void CallAnimator()
    {
        
        AnimMagnit.Play("animMagnit");
       // StartCoroutine("DelayinUnityScene");
       // StartCoroutine("AlphaParamChangeCall");
    }


}
