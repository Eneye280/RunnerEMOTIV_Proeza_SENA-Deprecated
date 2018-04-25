using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIJugador : MonoBehaviour 
{
	[SerializeField] private Image imageSalud;
	[SerializeField] private GameObject textoNombre;
	[SerializeField] private int tamañaLetra;
  	private void Awake()
	{
		imageSalud.fillAmount = 1;
		textoNombre = GetComponent<GameObject>();
	}
	private void Start()
	{
		MostrarNombre();
 	}

	private void Update () 
	{
		SaludJugador();
	}

	#region Salud
	private void SaludJugador()
	{
		if(CompareTag("mataVenenosa"))
		{
			imageSalud.fillAmount -= 0.1f;
		}
		else if(CompareTag("obstaculo"))
		{
			imageSalud.fillAmount -=0.3f;
		}
	}
	#endregion

	#region Mostrar Nombre
	private void MostrarNombre()
	{
		textoNombre = GameObject.FindGameObjectWithTag("nombreusuario");
		textoNombre.GetComponent<Text>().text = Login.login.textNombre.text;
		textoNombre.GetComponent<Text>().font = Login.login.fuente;
		textoNombre.GetComponent<Text>().fontSize = tamañaLetra;
	}
	#endregion
}
