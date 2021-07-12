using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Использование сопрограммы
//Позволяет приостоновить выполнение и вернуть управление Unity
//затем продолжить с того же места, где остановиласт в седующем кадре
public class AlphaScriptProvod : MonoBehaviour
{
    /// Start is called before the first frame update
    /// 

    [SerializeField] private ParcticalControll parcticalControllPlay;
    //[SerializeField] private AmperCurrent amperCurrent;
    Color color_;


    void Start()
    {
        parcticalControllPlay.StartParcticalSystem();


    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.F))
    //    {
    //        Debug.Log("F");
    //        StartCoroutine("Fade");

    //    }

    //}

    //,Объявление сопрограммы



    public IEnumerator Fade()
    {
        //int t = 0;
        //while (t < 1000) ++t;

        for (float ft = 1f; ft >= 0.5; ft -= 0.01f)
        {
            //Color c = GetComponent<MeshRenderer>().material.color;
            if (ft == 1f) yield return new WaitForSeconds(5f);
            color_ = gameObject.GetComponent<Renderer>().material.color;
            color_.a = ft;
            gameObject.GetComponent<Renderer>().material.color = color_;
            //GetComponent<MeshRenderer>().material.color = c;
            //if (color_.a == 0.123)//(gameObject.GetComponent<Renderer>().material.color.a == 123)
            //{ Debug.Log("Exit");  yield break; } ///StopCoroutine("Fade");
            yield return null; ///точка, в котором выполнение будет приостановлено
                               ///и возобнавлено в следующем кадре


        }

        //parcticalControllPlay.StartParcticalSystem();
        //yield return new WaitForSeconds(5f);
        // amperCurrent.DirectOnProvod();

    }
    
    ///Также можно было ввести задержку по времени
    /// yield return new WaitForSeconds(.1f);
    /// IEnumerator DoCheck()
    /// {
    ///    for(;;)
    ///    {
    ///       /*function*/
    ///       yeld return new...
    ///    }
    /// }
    /// 

    ///Остановка
    ///StopAllCoroutines
    ///StopCoroutine
    ///

    public void StartCor()
    {
       
        StartCoroutine("Fade");
    }
}
