using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    
	void Start ()
    {
		
	}
	
	void Update ()
    {
        //Walk forward
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //Jump
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("UP");
        }

        //Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("LEFT");
        }

        //Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("RIGHT");
        }

        transform.Translate(0, 0, z);
    }
}
