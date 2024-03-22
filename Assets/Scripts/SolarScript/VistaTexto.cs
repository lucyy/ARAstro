using UnityEngine;
using System.Collections;

public class VistaTexto : MonoBehaviour {
	//Delaracion de variable
	public GameObject goCamara;

	void Update () {
		//el texto mira hacia la camara
		transform.LookAt (goCamara.transform);
	}
}
