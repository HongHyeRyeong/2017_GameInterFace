using UnityEngine.SceneManagement;
using UnityEngine;


public class ButtonGo : MonoBehaviour
{
    public void ReadyButton()
    {
        SceneManager.LoadScene("Ready");
    }

    public void StartButton()
    {

       SceneManager.LoadScene("PlayGame");

    }

    public void ShopButton()
	{
		SceneManager.LoadScene ("Shop");
	}
}