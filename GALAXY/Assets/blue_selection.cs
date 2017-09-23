using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blue_selection : MonoBehaviour
{
    //public coin coin;
    GameObject obj;
    Text text;
    GameObject obj3;
    Text text3;
 
    int bluecoin = 100;
    bool check = false;

    public void OnMouseDown()
    {
        obj = GameObject.Find("BuyCoin");
        obj3 = GameObject.Find("BuyButtonText");
        text3 = obj3.GetComponent<Text>();

        text = obj.GetComponent<Text>();
        text.text = bluecoin.ToString();

        if (coin.blue == true)
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
        if (check == false && coin.blue == false)
        {
            text3.text = "SELECT";
            check = true;
        }
    }
}
