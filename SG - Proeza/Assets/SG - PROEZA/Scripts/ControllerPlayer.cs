using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour 
{
	[SerializeField] private float velocidad;
	void Update () 
	{
		float vertical = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
		float horizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;

		transform.Translate(horizontal,0,vertical);
	}
}
