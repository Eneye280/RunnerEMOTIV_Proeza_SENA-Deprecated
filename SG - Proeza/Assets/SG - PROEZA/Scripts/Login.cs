using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour 
{
	public static Login login;
	[SerializeField] private InputField inputField;
	[SerializeField] public Text textNombre;
	[SerializeField] public Font fuente;
	[SerializeField] private GameObject[] enableDisable;

   	[HideInInspector] private string nombreInicial = "Ingrese su Nombre";

	private void Awake()
	{
		if(login == null) login = this;
		else Destroy(this);

		enableDisable[0].SetActive(false);
		enableDisable[1].SetActive(false);
		enableDisable[2].SetActive(true);

		inputField.placeholder.GetComponent<Text>().text = nombreInicial.ToString();
		inputField.placeholder.GetComponent<Text>().font = fuente;
		inputField.placeholder.GetComponent<Text>().color = Color.black;
	}
	private void Update()
	{
		
	}
	public void Play () 
	{
		enableDisable[0].SetActive(true);
		enableDisable[1].SetActive(true);
		enableDisable[2].SetActive(false);
	}
}
