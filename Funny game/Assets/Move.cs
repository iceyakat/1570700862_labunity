using UnityEngine;
using System.Collections;


public class Move : MonoBehaviour
{

	void Update ()
	{

		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate(Vector2.up* Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Translate(Vector2.down* Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(Vector2.right* Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Translate(Vector2.left* Time.deltaTime);
		}
	}
}