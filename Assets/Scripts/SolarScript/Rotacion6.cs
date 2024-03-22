using UnityEngine;
using System.Collections;

public class Rotacion6 : MonoBehaviour {
	//Declaracion de variables
	public Transform cuerpoReferencia6;
	float velocidad=6f;

	void Update () {
		//El planeta rota alrededor del sol, del eje Y, con la velocidad espeficicada
		transform.RotateAround (cuerpoReferencia6.position, transform.up, velocidad*Time.deltaTime);
	}
}
