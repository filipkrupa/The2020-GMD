using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private float moveSpeed = 130f;
    private float movement = 0f;

    [SerializeField]
    GameObject gameObject;






    // Update is called once per frame
    void Update()
    {

        movement = Input.GetAxis("Horizontal");

    }
    public void FixedUpdate()
    {

        
        transform.RotateAround(gameObject.transform.parent.position, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

   



}