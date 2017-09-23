using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yellow_selection : MonoBehaviour
{
    GameObject obj;
    Text text;
    GameObject obj3;
    Text text3;

    int yellowcoin = 300;
    bool check = false;

    public void OnMouseDown()
    {
        obj = GameObject.Find("BuyCoin");
        obj3 = GameObject.Find("BuyButtonText");
        text3 = obj3.GetComponent<Text>();

        text = obj.GetComponent<Text>();
        text.text = yellowcoin.ToString();

        if (coin.yellow == true)
        {
            text3.text = "BUY";
        }
        else
        {
            text3.text = "SELECT";
        }
    }

    private void Update()
    {
        if (check == false && coin.yellow == false)
        {
            text3.text = "SELECT";
            check = true;
        }
    }
}
