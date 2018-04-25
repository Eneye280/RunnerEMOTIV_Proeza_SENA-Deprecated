using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour 
{
	[SerializeField] private float velocidad;
	[SerializeField] private GameObject parallax;
	private void Update () 
	{
		Parallax();
	}

	private void Parallax()
	{
		if(Login.login.enableDisable[1].activeSelf)
			parallax.transform.Translate(-Vector3.forward * velocidad * Time.deltaTime);
	}
}
