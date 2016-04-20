using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class controll : MonoBehaviour {
	public Button Button;
	public Button Buttons;
	public Text GameOver;
	// Use this for initialization
	void Start () {
		Button.gameObject.SetActive (false);
		Buttons.gameObject.SetActive (false);
		GameOver.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
