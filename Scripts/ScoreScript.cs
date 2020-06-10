using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{


    public static int scoreValue;
    //public int finalValue = 0;

    
    Text score;
    //FinalScore finalScore;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;

    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score " + scoreValue;


    }

    public void setValue(int value)
    {
        scoreValue += value;
        //finalValue += value;
        //score.text = "Score " + scoreValue;

    }

    public int getValue()
    {
        return scoreValue;
    }

    

}
