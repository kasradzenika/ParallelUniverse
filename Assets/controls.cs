using UnityEngine;

using System.Collections;


public class controls : MonoBehaviour {

    public float moveSpeed;
    public float maxSpeed;

	void Update () {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        Vector2 dir = (Vector2.right * hor + Vector2.up * ver) * moveSpeed;

        if(rigidbody2D.velocity.magnitude < maxSpeed){
            rigidbody2D.AddForce(dir);
        }
	}

}
