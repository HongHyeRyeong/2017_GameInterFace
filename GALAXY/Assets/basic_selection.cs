using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basic_selection : MonoBehaviour {

    GameObject obj;
    Text text;
    GameObject obj3;
    Text text3;

    int basiccoin = 0;

    public void OnMouseDown()
    {
        obj = GameObject.Find("BuyCoin");
        obj3 = GameObject.Find("BuyButtonText");
        text3 = obj3.GetComponent<Text>();

        text = obj.GetComponent<Text>();
        text.text = basiccoin.ToString();

        text3.text = "SELECT";
    }
}
