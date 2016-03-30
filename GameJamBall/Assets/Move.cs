using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	void Start ()
	{
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3 (-3, 0, 0);
	}

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag== "cubeleft")
		{
			Destroy(this.gameObject);
		}
	}
}