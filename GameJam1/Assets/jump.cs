using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;  
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate()
	{

		if (Input.GetKey(KeyCode.Space))
		{
			rb.AddForce(Vector3.up * speed);
		}

	}
}