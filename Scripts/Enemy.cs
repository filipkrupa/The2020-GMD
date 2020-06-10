using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Enemy : MonoBehaviour
{
    public int health = 100;
   

    public GameObject deathEffect;
    public AudioSource audioData;


    public void TakeDemage (int demage)
    {
        audioData = GetComponent<AudioSource>();
        health -= demage;
        if(health <= 0)
        {
            Die();
            ScoreScript.scoreValue += 5;
            audioData.Play(0);
          
        }
       
            
            

    }


    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Debug.Log("started");
        Destroy(gameObject);
        Destroy(deathEffect.gameObject, 0.3f);
    }
}
