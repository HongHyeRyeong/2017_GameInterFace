using UnityEngine;
using UnityEngine.UI;

public class Gamecoin : MonoBehaviour
{
    //게임화면 코인 부분
    static Text Gametext;

    void Start()
    {
        Gametext = GetComponent<Text>();
        Gametext.text= coin._coin.ToString();
    }

    public static void AddCoin(int newCoinValue)
    {
        coin._coin += newCoinValue;
        Gametext.text = coin._coin.ToString();
    }
}