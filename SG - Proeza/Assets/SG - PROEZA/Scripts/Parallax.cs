using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour 
{
	[SerializeField] private float velocidad;
	[SerializeField] private GameObject parallax;
	private void Update () 
	{
		ParallaxGame();
	}

	private void ParallaxGame()
	{
		if(Login.login.enableDisable[1].activeSelf)
			parallax.transform.Translate(-Vector3.forward * velocidad * Time.deltaTime);
	}
}
