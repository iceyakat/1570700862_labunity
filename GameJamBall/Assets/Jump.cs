using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;  
	bool canjump;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	public void jumper()
	{
		if (canjump) {
			rb.velocity = Vector3.up * speed;
		}
	}
	void OnCollisionEnter(Collision other) {

		if (other.gameObject.tag== "cube")
		{
			canjump = true;
		}

	}
	void OnCollisionExit(Collision other) {

		if (other.gameObject.tag == "cube") {
			canjump = false;
		}
	}
}