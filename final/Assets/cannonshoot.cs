using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class cannonshoot: MonoBehaviour
{
	public Rigidbody projectile;
	public Transform shotPos;
	public int shotForce ;
	public int Speed ;
	public Text bullet;
	public int count;
	public Button Button;
	public Button Buttons;
	public Text GameOver;
	void Start ()
	{
		count = 3;
		bull ();
		Button.gameObject.SetActive (false);
		Buttons.gameObject.SetActive (false);
		GameOver.gameObject.SetActive (false);
		//Cannon = Instantiate (Resources.Load ("Prefabs/Cannon")) as GameObject;

	}
 void Update ()
	{

		}
	public void speed ()
	{

	}
	public void shoot ()
	{
		if (count == 0) {
			Button.gameObject.SetActive (true);
			Buttons.gameObject.SetActive (true);
			GameOver.gameObject.SetActive (true);
		}

		Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
		shot.velocity=new Vector3(1,1,0) * shotForce ;
		count--;
		bull ();

	}
void bull ()
	{
		bullet.text = "Count: " + count.ToString ();
	}
	}

