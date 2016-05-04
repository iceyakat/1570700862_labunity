using UnityEngine;
using System.Collections;

public class Wallupdown : MonoBehaviour 
{
	public int maxSpeed;

	private Vector3 startPosition;

	void Start () 
	{
		maxSpeed = 3;

		startPosition = transform.position;
	}


	void Update ()
	{
		MoveVertical ();
	}

	void MoveVertical()
	{
		transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);

		if(transform.position.y > 1.0f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		}
		else if(transform.position.y < -1.0f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		}
	}
}