using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetElectroneAnimator : MonoBehaviour
{

    private Animator animElectroneController;
    [SerializeField]
    private UIPoup electron_Ptr;
    [SerializeField]
    private UIPoup current_ptr;

    void Start()
    {
        animElectroneController = GetComponent<Animator>();
    }

    public void GetElectroneAnim()
    {
        electron_Ptr.Open();
        current_ptr.Open();
        animElectroneController.Play("ElectroneAnimator");
    }

    
}
