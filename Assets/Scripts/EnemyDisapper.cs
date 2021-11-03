using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisapper : MonoBehaviour
{
   
    Vector2 direction;
    public GameObject myobj;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.right;
       
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        { 
            whenspaceclick();
        }
        
    }
    
    public void whenspaceclick()
    {

            if(myobj.activeInHierarchy == true)
            {
                myobj.SetActive(false);
            }
            else
            {
                 myobj.SetActive(true);
            }
   
    }

}
