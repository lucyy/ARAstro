using UnityEngine;
using System.Collections;

public class Rotacion7: MonoBehaviour {
	//Declaracion de variables
	public Transform cuerpoReferencia7;
	float velocidad=7f;

	void Update () {
		//El planeta rota alrededor del sol, del eje Y, con la velocidad espeficicada
		transform.RotateAround (cuerpoReferencia7.position, transform.up, velocidad*Time.deltaTime);
	}
}
