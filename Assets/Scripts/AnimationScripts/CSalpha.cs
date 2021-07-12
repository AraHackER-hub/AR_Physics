using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSalpha : MonoBehaviour
{
    public bool start = false;
    public Color color_;
    public float step;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.F))
        {
            start = true;
        }

        if (start)
        {
            color_ = gameObject.GetComponent<Renderer>().material.color;
            if (color_.a > 0)
            {
                color_.a = step / 100;
                gameObject.GetComponent<Renderer>().material.color = color_;
            }
        }

        
    }
}
