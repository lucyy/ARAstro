using UnityEngine;
using System.Collections;

public class Rotacion55 : MonoBehaviour {
	//Declaracion de variables
	public Transform cuerpoReferencia55;
	float velocidad=5.5f;

	void Update () {
		//El planeta rota alrededor del sol, del eje Y, con la velocidad espeficicada
		transform.RotateAround (cuerpoReferencia55.position, transform.up, velocidad*Time.deltaTime);
	}
}
