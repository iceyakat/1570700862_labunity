using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coin : MonoBehaviour {
	public Text countText;
	private int count;
	void Start ()
	{
		//Rigidbody rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		countText.text = "Score: " + count.ToString ();

	}

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag== "coin")
		{
			Destroy(this.gameObject);
			count++;
			SetCountText ();
		}

	}
		
	void SetCountText ()
	{
		countText.text = "Score: " + count.ToString ();

	}
}