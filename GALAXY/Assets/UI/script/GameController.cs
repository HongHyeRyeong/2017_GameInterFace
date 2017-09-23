using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    GameObject objPlanet;
    Mesh mesh;

    public void left()
    {
        objPlanet = GameObject.Find("Planet");
        objPlanet.transform.Rotate(0.0f, 90.0f * Time.deltaTime*5, 0.0f);
    }

    public void right()
    {
        objPlanet = GameObject.Find("Planet");
        objPlanet.transform.Rotate(0.0f, -90.0f * Time.deltaTime*5, 0.0f);
    }
} 
