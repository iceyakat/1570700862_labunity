using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Death : MonoBehaviour {
	
	void Start ()
	{
		//Rigidbody rb = GetComponent<Rigidbody> ();


	}

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag== "enemy"||other.gameObject.tag== "enem")
		{
			Destroy(this.gameObject);
	
		}

	}
}