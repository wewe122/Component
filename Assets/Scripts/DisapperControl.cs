using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapperControl : MonoBehaviour
{
    
     public GameObject myobj;
     
     bool hide = false;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            hide = !hide;
          
            if (hide)
            {
                myobj.SetActive(false);
            }
            else
            {
                myobj.SetActive(true);

            }
            
        }

        

        
    }

}


