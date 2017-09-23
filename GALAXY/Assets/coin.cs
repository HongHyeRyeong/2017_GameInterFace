using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour {

    public static coin instance;

    GameObject obj;
    static Text text;
    GameObject obj2;
    Text text2;
    GameObject obj3;
    Text text3;

    public static int _coin = 1000;
    public static bool blue = true;
    public static bool yellow = true;
    public static bool black = true;

    public static bool basiccheck = false;
    public static bool bluecheck = false;
    public static bool yellowcheck = false;
    public static bool blackcheck = false;

   // public GameObject sound;


    public void Purchase()
    {
        obj = GameObject.Find("CoinNum");
        text = obj.GetComponent<Text>();
        obj2 = GameObject.Find("BuyCoin");
        text2 = obj2.GetComponent<Text>();
        obj3 = GameObject.Find("BuyButtonText");
        text3 = obj3.GetComponent<Text>();

        if (text2.text == "100" && blue == true && _coin >= 100)
        {
            _coin -= 100;
            //Instantiate(sound);

            blue = false;
        }
        if (text2.text == "300" && yellow == true && _coin >= 300)
        {
            _coin -= 300;
            //Instantiate(sound);
            yellow = false;
        }
        if (text2.text == "1000" && black == true && _coin >= 1000)
        {
            _coin -= 1000;
           // Instantiate(sound);
            black = false;
        }

        if(text2.text == "100" && blue == false)
        {
            bluecheck = true;
           // Instantiate(sound);
            basiccheck = false;
            yellowcheck = false;
            blackcheck = false;
        }
        if (text2.text == "300" && yellow == false)
        {
            yellowcheck = true;
            basiccheck = false;
            bluecheck = false;
            blackcheck = false;
        }
        if (text2.text == "1000" && black == false)
        {
            blackcheck = true;
            basiccheck = false;
            yellowcheck = false;
            bluecheck = false;
        }
        if (text2.text == "0")
        {
            basiccheck = true;
            bluecheck = false;
            yellowcheck = false;
            blackcheck = false;
        }

        text.text = _coin.ToString();
    }
}
