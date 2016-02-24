using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues;
	public Vector3 spawnrota;

	void Start ()
	{
		SpawnWaves ();
	}

	void SpawnWaves ()
	{
		Vector3 spawnPosition = new Vector3 (spawnValues.y,Random.Range (-spawnValues.x, spawnValues.x), spawnValues.z);
		//Vector3 spawnRotation= new Vector3 (spawnrota.x,spawnrota.y, spawnrota.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (hazard, spawnPosition, spawnRotation);
	}
}