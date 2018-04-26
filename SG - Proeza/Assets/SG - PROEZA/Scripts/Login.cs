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
	[SerializeField] private Camera cameraMain;
	[SerializeField] internal GameObject[] enableDisable;

   	[HideInInspector] private string nombreInicial = "Ingrese su Nombre";

	private void Awake()
	{

#region Singleton

		if(login == null) login = this;
		else Destroy(this);
		
#endregion

		enableDisable[0].SetActive(false);
		enableDisable[1].SetActive(false);
		enableDisable[2].SetActive(true);

		inputField.placeholder.GetComponent<Text>().text = nombreInicial.ToString();
		inputField.placeholder.GetComponent<Text>().font = fuente;
		inputField.placeholder.GetComponent<Text>().color = Color.black;

#region Camera
		cameraMain.clearFlags = CameraClearFlags.SolidColor;
		cameraMain.backgroundColor = Color.white;
		cameraMain.renderingPath = RenderingPath.DeferredShading;
		cameraMain.farClipPlane = 0.31f;
		cameraMain.allowMSAA = false;
#endregion

	}

	private void Update()
	{
		if(enableDisable[1].activeSelf)
		{
			
		}
	}

#region Boton Inicio
	public void Play () 
	{
		enableDisable[0].SetActive(true);
		enableDisable[1].SetActive(true);
		enableDisable[2].SetActive(false);
	}
#endregion

}
