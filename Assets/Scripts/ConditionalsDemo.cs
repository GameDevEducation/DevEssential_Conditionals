using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsDemo : MonoBehaviour
{
    public Vector3 MovementPerFrame;
    public float YBounds = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // // Only update the position if the y value is between -2 and 2 [Bad Version]
        // // Has the issue that it can go out of bounds if MovementPerFrame is large enough
        // if (transform.position.y < 2f)
        // {
        //     if (transform.position.y > -2f)
        //     {
        //         transform.position = transform.position + MovementPerFrame;
        //     }
        // }

        // // Only update the position if the y value is between -2 and 2 [Version 1]
        // // Cannot go out bounds
        // if ((transform.position.y + MovementPerFrame.y) < 2f)
        // {
        //     if ((transform.position.y + MovementPerFrame.y) > -2f)
        //     {
        //         transform.position = transform.position + MovementPerFrame;
        //     }
        // }   

        // // Only update the position if the y value is between -2 and 2 [Version 2]
        // // && = AND ie both conditions must be met
        // if (((transform.position.y + MovementPerFrame.y) < 2f) && ((transform.position.y + MovementPerFrame.y) > -2f))
        // {
        //     transform.position = transform.position + MovementPerFrame;
        // }

        // // Only update the position if the y value is between -2 and 2 [Version 3]
        // if (Mathf.Abs(transform.position.y + MovementPerFrame.y) < 2f)
        // {
        //     transform.position = transform.position + MovementPerFrame;
        // }

        // Only update the position if the y value is between -YBounds and YBounds [Version 3a - Now with variables!]
        if (Mathf.Abs(transform.position.y + MovementPerFrame.y) < YBounds)
        {
            transform.position = transform.position + MovementPerFrame;
        }        
    }
}
