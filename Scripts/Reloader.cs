using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloader : MonoBehaviour
{
    public GameObject ss;

    // Start is called before the first frame update
    void Start()
    {

        ss = GameObject.Find("ScoreCanvas");
        Invoke("ScaneChanger", 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScaneChanger()
    {
        
        Destroy(ss, 0f);
        
        SceneManager.LoadScene("Main");

    }
}
