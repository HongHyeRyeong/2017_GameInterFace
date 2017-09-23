using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {


    public static bool isPaused;

    void start()
    {
        isPaused = false;
    }

    void Update()
    {
        if (isPaused.Equals(true))
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void Pause()
    {
        isPaused = true;
    }

    public void Resume()
    {
        isPaused = false;
    }
}
