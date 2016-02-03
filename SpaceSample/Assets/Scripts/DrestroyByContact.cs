using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
	
	void OnTriggerEnter(Collider other)
	{
		//avoid destruction by our game box boundary
		if(other.tag == "Boundary")
		{
			return;
		}
		Object.DestroyObject(other.gameObject);
		Object.DestroyObject(gameObject);
	}
}﻿