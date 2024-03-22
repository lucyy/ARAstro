using UnityEngine;
using System.Collections;

public class Rotacion65 : MonoBehaviour {
	//declaracion de variables
	public Transform cuerpoReferencia65;
    float velocidad=6.5f;

	void Update () {
		//El planeta rota alrededor del sol, del eje Y, con la velocidad espeficicada
		transform.RotateAround (cuerpoReferencia65.position, transform.up, velocidad*Time.deltaTime);
	}
}
