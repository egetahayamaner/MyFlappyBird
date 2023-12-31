using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
     public Rigidbody2D myRigidbody;
     public float flapStrenght;
     public LogicScript logic;
     public bool birdIsAlive = true;
     public float dead = -75f;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {    
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true){
            myRigidbody.velocity = Vector2.up * flapStrenght;
        } 
        if(transform.position.y < dead)
        {
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false; 
    }
}
