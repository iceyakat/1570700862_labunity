using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Death : MonoBehaviour {
	public Button Button;
	public Button Buttons;
	public Text GameOver;
	void Start ()
	{
		//Rigidbody rb = GetComponent<Rigidbody> ();
		Button.gameObject.SetActive (false);
		Buttons.gameObject.SetActive (false);
		GameOver.gameObject.SetActive (false);

	}

	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag== "enemy")
		{
			Destroy(this.gameObject);
			Button.gameObject.SetActive (true);
			Buttons.gameObject.SetActive (true);
			GameOver.gameObject.SetActive (true);
		}

	}
}