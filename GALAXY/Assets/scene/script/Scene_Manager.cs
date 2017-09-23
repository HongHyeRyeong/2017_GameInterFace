using UnityEngine.SceneManagement;
using UnityEngine;

public class Scene_Manager : MonoBehaviour
{    
    public float timeCount = 0;

 

    void Update()
    {
        
        timeCount += Time.deltaTime;
        if (timeCount > 1)
            SceneManager.LoadScene("Ready");

    }














}
