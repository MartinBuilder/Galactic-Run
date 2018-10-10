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
        var z = Time.deltaTime * 10.0f;
        var y = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;

        //Jump
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("UP");
        }
        transform.Translate(y, 0, z);
    }
}
