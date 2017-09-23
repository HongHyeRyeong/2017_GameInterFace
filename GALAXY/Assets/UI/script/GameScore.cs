using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    Text ScoreNowText;
    static float ScoreNow;
    static int ScoreBest = 0;

    void Start()
    {
        if (Application.loadedLevelName == "playGame")
            ScoreNowText = GameObject.Find("ScoreNow").GetComponent<Text>();
        ScoreNow = 0.0f;
    }

    void Update()
    {
        if (Application.loadedLevelName == "playGame")
        {
            if (PauseGame.isPaused == false) ScoreNow += 0.05f;

            int temp = (int)ScoreNow;
            ScoreNowText.text = temp.ToString();

            GameEnd();

        }
        else
        {
            Text ScoreBestText;
            ScoreBestText = GameObject.Find("Score").GetComponent<Text>();
            ScoreBestText.text = ScoreBest.ToString();
        }
    }

    public static void GameEnd()
    {
        if ((int)ScoreNow > ScoreBest)
        {
            ScoreBest = (int)ScoreNow;

            Text text = GameObject.Find("New").GetComponent<Text>();
            text.text = "NEW!!";
        }
    }
}