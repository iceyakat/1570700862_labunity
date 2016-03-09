using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
	public GameObject explosion;

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag== "Cubes"||other.gameObject.tag== "Cubeleft")
		{
			Instantiate(explosion, transform.position, transform.rotation);
				Destroy(this.gameObject);
		}
	}
	void OnCollisionExit(Collision other) 
	{
		if (other.gameObject.tag== "Cylinder")
		{
			Rigidbody rb = GetComponent<Rigidbody> ();
			rb.velocity = new Vector3 (0, rb.velocity.y, 0);
		}
}
}