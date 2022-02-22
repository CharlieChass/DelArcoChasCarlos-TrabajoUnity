using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dirX toma valores entre -1 y 1.
        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        //Movimiento del personaje
    
        rb.velocity = new Vector2(dirX*5, rb.velocity.y);


        if(Input.GetKeyDown("space")){{
            rb.velocity = new Vector2(rb.velocity.x,10);
        }
        }
    }
}
