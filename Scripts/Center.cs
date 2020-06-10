using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Center : MonoBehaviour
{

    private float speed = 130f;    // Here we set a float variable to hold our speed value
    [SerializeField]
    private Rigidbody2D rb;  // This is to hold the rigidbody component

    public GameObject scoreObj;

    // Start is called as you start the game, we use it to initially give values to things
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Here we actually reference the rigidbody.
        
         
        
    }

    void FixedUpdate()
    {
        // We assign values based on our input here:
        float moveHorizontal = 0f;
        float moveVertical = Input.GetAxis("Vertical");
        rb.velocity = (transform.forward * moveVertical) * speed * Time.deltaTime;

        // Here we assign those values to a Vector2 variable.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.AddForce(movement * speed);    // Finally we apply the forces to the rigidbody
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        SceneManager.LoadScene("Dead");

        
    }
}
