using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Импорт инфраструктуры для работы с кодом UI
using UnityEngine.SceneManagement;


public class UIcontroller : MonoBehaviour
{

    [SerializeField] private Text scoreLable;
    [SerializeField] private UIPoup uibackground;
    [SerializeField] private UIPoup buttonActive;
    [SerializeField] private UIPoup buttonforMagnit_Active;
    [SerializeField] private ProvodGetAnimator CallMgnitAnimatorController;
    [SerializeField] private UIPoup Electrone;
    //[SerializeField] private UIPoup Current;
    [SerializeField] private UIPoup CurrentAmper;
    [SerializeField] private GetElectroneAnimator electrone;
    [SerializeField] private GetCurrentAnim current;
    [SerializeField] private UIPoup AmperSource;
    [SerializeField] private UIPoup BACK;
    [SerializeField] private UIPoup RESTART;
    [SerializeField] private UIPoup playClose;
    [SerializeField] private UIPoup opensourceClose;
    // Start is called before the first frame update
    void Start()
    {
        uibackground.Open();
        buttonActive.Close();
        buttonforMagnit_Active.Close();
        Electrone.Close();
       // Current.Close();
        CurrentAmper.Close();
        AmperSource.Close();
        RESTART.Close();
    }


    // Update is called once per frame
    void Update()
    {
        //scoreLable.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnCloseSetting()
    {
        uibackground.Close();
        buttonActive.Open();
        buttonforMagnit_Active.Open();
        RESTART.Open();
    }

    public void ChanelBackGround()
    {
        uibackground.Open();
        buttonActive.Close();
        buttonforMagnit_Active.Close();
        RESTART.Close();
    }

    public void CallAnimation()
    {
        CallMgnitAnimatorController.CallAnimator();
        Electrone.Open();
        //Current.Open();
        CurrentAmper.Open();
        electrone.GetElectroneAnim();
        current.get_CurrentAnimator();
    }

    public void SourceAmper()
    {
        AmperSource.Open();
        BACK.Close();
        opensourceClose.Close();
        playClose.Close();
        //Закрыть остальные кнопки
    }

    public void AmperClose()
    {
        AmperSource.Close();
        BACK.Open();
        opensourceClose.Open();
        playClose.Open();
        //Открыть остальные кнопки
    }

    public void BACKApplocationUniy()
    {
        Application.Quit();
    }

    public void ReSTARTApplicationUniy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
