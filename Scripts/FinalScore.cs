using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public int scoreValue = 1;
    Text score;
    public GameObject ss;
    


    // Start is called before the first frame update
    void Start()
    {
       
         ss = GameObject.Find("ScoreCanvas");
         ss.gameObject.SetActive(false);
        
         score = GetComponent<Text>();
    }

    void Update()
    {
        scoreValue = ss.GetComponentInChildren<ScoreScript>().getValue();
        score.text = "Final score: " + scoreValue;

    }


    public int getValue()
    {
        return scoreValue;
    }
    

}
