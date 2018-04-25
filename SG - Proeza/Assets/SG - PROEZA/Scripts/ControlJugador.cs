using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour 
{
	[SerializeField] private float velocidad;
	void Update () 
	{
		Control();
	}

	private void Control()
	{
		float horizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;

		transform.Translate(horizontal,0,0);
	}
}
