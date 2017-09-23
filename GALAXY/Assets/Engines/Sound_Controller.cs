using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Controller : MonoBehaviour {

    public AudioSource ado;
    bool On;

    void Start()
    {
        On = true;
        if (On == true)
            ado.volume = 1;
    }

    public void Play_Sound()
    {
        ado.volume = 1.0f;
    }
    public void Stop_Sound()
    {
        ado.volume = 0;
    }

}
