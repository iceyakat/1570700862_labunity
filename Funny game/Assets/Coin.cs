using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	void Start ()
	{
		//Rigidbody rb = GetComponent<Rigidbody> ();

	}

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag== "coin")
		{
			Destroy(this.gameObject);
		}

	}
}