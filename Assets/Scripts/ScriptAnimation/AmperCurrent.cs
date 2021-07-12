using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmperCurrent : MonoBehaviour
{
    public float Speed = 1f;
    public Vector3 Directional = Vector3.zero;
    Transform ThisTransform;

    void Start()
    {
        ThisTransform = GetComponent<Transform>();
    }


    public void DirectOnProvod()
    {
        while (ThisTransform.position.z != 1f)
        ThisTransform.position += Directional.normalized * Speed * Time.deltaTime;
    }

}
