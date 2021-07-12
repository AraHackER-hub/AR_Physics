using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParcticalControll : MonoBehaviour
{
    private ParticleSystem parcticalLouncher = null;

    public void StartParcticalSystem()
    {
        parcticalLouncher = GetComponent<ParticleSystem>();
        parcticalLouncher.Play();
    }
}
