﻿using UnityEngine;
using System.Collections;

public class scene : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void DoPlayAgain(){
		Application.LoadLevel (0);
	}
	public void Play(){
		Application.LoadLevel (1);
	}
}