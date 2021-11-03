using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Start is called before the first frame update   
    
    Rigidbody2D rb2d;

     float moveSpeed=0;
     float leftAngle=-0.1f;
     float rightAngle=0.1f;


    bool movingClockwise;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        movingClockwise = true;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        Move();
    }

    public void ChangeMoveDir()
    {
        if (transform.rotation.z > rightAngle)
        {
            if(rightAngle<=0.3)
              rightAngle+=0.09f;
            movingClockwise = false;
        }
        if (transform.rotation.z < leftAngle)
        {
            if(leftAngle>=-0.3)
              leftAngle+=-0.09f;
            movingClockwise = true;
        }

    }

    public void Move()
    {
        ChangeMoveDir();
        if(moveSpeed<=55)
        {
            moveSpeed+=1;
        }

        if (movingClockwise)
        {
            
            rb2d.angularVelocity = moveSpeed;
        }

        if (!movingClockwise)
        {
            rb2d.angularVelocity = -1*moveSpeed;
        }
    }


}
