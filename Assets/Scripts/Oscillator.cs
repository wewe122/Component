using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Start is called before the first frame update   
    
     Rigidbody2D rb2d;

     private float moveSpeed=0;
     private float leftAngle=-0.1f;
     private float rightAngle=0.1f;
     private float AddRangeRotation=0.01f;
     private float MaxRangeForRotation=0.3f;
     private float MaxSpeedForMove=55;
     private bool movingClockwise;
   
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
            if(rightAngle<=MaxRangeForRotation)
              rightAngle+=AddRangeRotation;
            movingClockwise = false;
        }
        if (transform.rotation.z < leftAngle)
        {
            if(leftAngle>=-MaxRangeForRotation)
              leftAngle+=-AddRangeRotation;
            movingClockwise = true;
        }

    }

    public void Move()
    {
        ChangeMoveDir();
        if(moveSpeed<=MaxSpeedForMove)
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
