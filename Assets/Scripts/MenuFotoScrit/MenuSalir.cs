using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuSalir: MonoBehaviour {

	void Start() {
		//la orientacion del menu de cada escena de RA es de acuerdo a la posicion del dispositivo
		Screen.orientation = ScreenOrientation.AutoRotation;
	}

	public void MenuEscena()
	{
		//se regresa al menu principal
		 SceneManager.LoadScene (0);
	}
	public void Salir()
	{
		//ce cierra la aplicacion
		Application.Quit ();
	}
}
