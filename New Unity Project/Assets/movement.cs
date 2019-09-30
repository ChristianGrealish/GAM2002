using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    //public variable of type float - decimal number
    public float f1_Movement = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKey("w"))
        {
            transform.Translate(f1_Movement, 0, 0);
        }

            if(Input.GetKey("s"))
        {
            transform.Translate(-f1_Movement, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(0,f1_Movement, 0);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(0,-f1_Movement,0);
        }





    }
}
