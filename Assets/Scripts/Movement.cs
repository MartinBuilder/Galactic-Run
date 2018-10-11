using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private bool isGrounded;

	void Start ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        isGrounded = true;
    }

    void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }

    void Update ()
    {
        //Walk forward
        var z = Time.deltaTime * 10.0f;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;

        //Jump
            if (Input.GetKey(KeyCode.Space) && isGrounded == true)
            {
                transform.Translate(x, 5, z);
            }
        transform.Translate(x, 0, z);
    }
}
