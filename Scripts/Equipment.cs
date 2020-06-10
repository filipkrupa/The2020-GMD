using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    //Array of objects to spawn (note I've removed the private goods variable)
    [SerializeField]
    public GameObject[] theGoodies = new GameObject[2];
    

    //Time it takes to spawn theGoodies
    [Space(3)]
    public float waitingForNextSpawn = 0.2f;
    public float theCountdown = 0.5f;

    // the range of X
    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    // the range of y
    [Header("Y Spawn Range")]
    public float yMin;
    public float yMax;

   

    // Start is called as you start the game, we use it to initially give values to things
    void Start()
    {
       
    }

    public void Update()
    {
        theCountdown -= Time.deltaTime;
        if (theCountdown <= 0)
        {
            SpawnGoodies();
            theCountdown = waitingForNextSpawn;
        }
        if (ScoreScript.scoreValue >= 800)
        {
            waitingForNextSpawn = 0.1f;

        }

    }

    public void Timer() {
        // timer to spawn the next goodie Object
        

    }



    void SpawnGoodies()
    {
        // Defines the min and max ranges for x and y
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));

        // Choose a new goods to spawn from the array (note I specifically call it a 'prefab' to avoid confusing myself!)
        GameObject goodsPrefab = theGoodies[Random.Range(0, theGoodies.Length)];

        // Creates the random object at the random 2D position.
        Instantiate(goodsPrefab, pos, Quaternion.identity);

        // If I wanted to get the result of instantiate and fiddle with it, I might do this instead:
        //GameObject newGoods = (GameObject)Instantiate(goodsPrefab, pos)
        //newgoods.something = somethingelse;

    }

 










}
