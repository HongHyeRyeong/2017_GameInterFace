using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class life_Manager : MonoBehaviour {
    private static int life;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;


    void Start () {
        life = 3;
    }

    public static void MinusLife()
    {
        life-=1;

    }

    public static int getLife() { return life; }

    void Update()
    {
        if (life == 2)
            Destroy(life3);
        if (life == 1)
            Destroy(life2);
        if (life == 0)
        SceneManager.LoadScene("Ready");

    }
}
