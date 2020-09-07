using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text score;
    public static int scoreAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score" + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score" + PlayerPrefs.GetInt("highscore");
    }
}
