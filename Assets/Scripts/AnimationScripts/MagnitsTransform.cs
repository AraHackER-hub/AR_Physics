using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Windows.Speech;
using System;
using System.Linq;

public class MagnitsTransform : MonoBehaviour
{
    //Прослушивает речь и пытается сопоставить произнесенные фразы с имеющим списком слов
    //private KeywordRecognizer keywordRecognizer;
    //Словарь, содержащий делегат, предусматривающий вызов действий в ответ на событие
    //private Dictionary<string, Action> action;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        /*action = new Dictionary<string, Action>();
        action.Add("forward", Go);
        action.Add("yes", Ye);
        action.Add("вперед", Forward);*/


       // keywordRecognizer = new KeywordRecognizer(action.Keys.ToArray());
        //Должно запускаться событие, когда фраза распознана
        //keywordRecognizer.OnPhraseRecognized += RecognizerSpeech;
        //keywordRecognizer.Start();
    }

    //тип аргумнта редоставляет информацию о распознаной фразе
    /*private void RecognizerSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        action[speech.text].Invoke();
    }

    private void Go()
    {

       // transform.Translate (0f, 0f, -1.5f);
        anim.Play("animMagnit");
    }

    private void Ye()
    {
        //transform.Translate(0f, 0f, -1.5f);
        anim.Play("animMagnit");
    }

    private void Forward()
    {
        anim.Play("animMagnit");
    }*/
}
