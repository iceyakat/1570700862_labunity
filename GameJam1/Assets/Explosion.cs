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
}