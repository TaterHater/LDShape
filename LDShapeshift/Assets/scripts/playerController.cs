using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

    public float speed;

	
	
	void FixedUpdate () {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(Vector3.left * Input.GetAxis("Horizontal") * speed);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed*-1);
        }

    }
}
