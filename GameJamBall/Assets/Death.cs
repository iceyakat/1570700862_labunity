using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Death : MonoBehaviour {
	public Button btnGameOver;
	public Text GameOver;
	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag== "Cubecheck")
		{
			btnGameOver.gameObject.SetActive (true);
			GameOver.gameObject.SetActive (true);
		}
}
}
