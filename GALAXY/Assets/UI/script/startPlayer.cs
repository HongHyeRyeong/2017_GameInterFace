using UnityEngine.SceneManagement;
using UnityEngine;

public class startPlayer : MonoBehaviour {
    bool isClick = false;
    public float speed;
    public float timeCount = 0;
 

    void Update()
    {
        transform.Translate(0, 0, speed);
        if (isClick)
        {
            timeCount += Time.deltaTime;
            if (timeCount > 1)
            {
                SceneManager.LoadScene("PlayGame");
            }
        }
    } 

	public void OnClick()
	{
        isClick = true;

        speed = 1;

    }

  
}