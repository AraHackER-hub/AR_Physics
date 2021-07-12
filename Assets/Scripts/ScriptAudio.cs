using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Threading;
//using UnityEngine.Windows.Speech;
using System.Linq;

public class ScriptAudio : MonoBehaviour
{
    // Start is called before the first frame update

    bool connected;

    void Start()
    {

        // audio.clip = Microphone.Start(null, true, 10, 44100);
        //audio.loop = true;
        //audio.mute = true;

        // while (!(Microphone.GetPosition() > 0)) ;
        //audio.Play();
        //AudioSource audioSource = GetComponent<AudioSource>();
        //audioSource.clip = Microphone.Start(null, true, 10, 44100);
        //audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
