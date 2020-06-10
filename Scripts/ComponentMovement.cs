using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentMovement : MonoBehaviour
{
    
    private float speed = 38f;    // Here we set a float variable to hold our speed value
    [SerializeField]
    private Rigidbody2D rb;  // This is to hold the rigidbody component

    // Start is called as you start the game, we use it to initially give values to things
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Here we actually reference the rigidbody.
        Destroy(gameObject, 8f);
        ScoreScript.scoreValue += 1;
    }

    void FixedUpdate()
    {
        // We assign values based on our input here:
        float moveHorizontal = -10f;
        float moveVertical = 0f;
        rb.velocity = (transform.right * moveVertical) * speed * Time.deltaTime;

        // Here we assign those values to a Vector2 variable.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.AddForce(movement * speed);    // Finally we apply the forces to the rigidbody
        if(ScoreScript.scoreValue > 0 && ScoreScript.scoreValue % 100 == 0){
            speed = 16;
            Invoke("speedUp", 5f);
            
        }
        
    }

    void speedUp()
    {
        speed = 38f;
    }
}
