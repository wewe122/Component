using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeBubble : MonoBehaviour
{
     Vector2 OrginalScale;
     private float NunberToReduceScale=1.20f;
    // Start is called before the first frame update
    void Start()
    {
        OrginalScale = transform.localScale;
        StartCoroutine(ChangeAnimeBubble());
    }

    IEnumerator ChangeAnimeBubble()
    {
        Vector2 SmallScale = OrginalScale / NunberToReduceScale;

        while(true)
        {
            transform.localScale = SmallScale;
            
            yield return new WaitForSeconds(0.2f);

            transform.localScale = OrginalScale;

            yield return new WaitForSeconds(0.2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
