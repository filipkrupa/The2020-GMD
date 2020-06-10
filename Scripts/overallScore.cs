using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overallScore : MonoBehaviour
{

    public GameObject scoreObj;
    // Start is called before the first frame update
    void Start()
    {
        scoreObj = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
