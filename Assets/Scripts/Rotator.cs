using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    private float rotZ;
    public float RotationSpeed;
    public bool ClockForRotation;
    // Update is called once per frame
    
    
    void Update()
    {
        if(ClockForRotation==false)
        {
            rotZ = rotZ + (Time.deltaTime * RotationSpeed);
        }
        
        else
        {
             rotZ = rotZ + (-Time.deltaTime * RotationSpeed);
        }

        transform.rotation = Quaternion.Euler(0,0,rotZ);
    }
}
