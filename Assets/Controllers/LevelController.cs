﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelController : MonoBehaviour {

	public Text deathCount;

	// Update is called once per frame
	void Update () {
		deathCount.text = "Dead: " + Universe.deathCount.ToString();

		if (!Universe.inverse) {
			GameObject.Find ("Main Camera").GetComponent<Camera> ().backgroundColor = Color.white;
		} else {
			GameObject.Find ("Main Camera").GetComponent<Camera> ().backgroundColor = Color.black;
		}
	}

}
