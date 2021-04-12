using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
    public int score;

    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        SetScoreCounter();
    }

    private void SetScoreCounter()
    {
        ScoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
