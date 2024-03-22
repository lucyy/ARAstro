using UnityEngine;
using System.Collections;

public class EstRayos : MonoBehaviour {

	//Declaración de variables
	public GameObject goMentenEstRayos;
	public GameObject goControlEstRayos;
	Vector3 posicionInicial;
	float velocidad=2f;
	double  indicadorEventos;
	bool targetPresente;

	void Start () {
		posicionInicial=transform.position;
	}

	void Update () {
		//Verifica la detección del target
	//	targetPresente= goControlEstRayos.GetComponent<ControlCapas> ().presenciaTarget;
		//Detecta el evento en el que se encuentra
		indicadorEventos = goMentenEstRayos.GetComponent<MentenEventos> ().indicador;
		//condición para verificar el evento y que haya detección de target
		if (indicadorEventos==18 ){// && targetPresente==true) {
			//trastalar los rayos hacia abajo con la velocidad especificada
			transform.Translate (-Vector3.up * Time.deltaTime * velocidad);
		}
		//condición para verificar el evento y que no haya detección de target
		if (indicadorEventos==25 ){// || targetPresente==false) {
			//los rayos se pausan
			transform.Translate (Vector3.zero);
		}
	}
	//Función para detectar colisión 
	void OnCollisionEnter(Collision colisionEst)
	{
		//cuando se detecta la colisión los rayos vuelven a la posición inicial
		transform.position = posicionInicial;
	}
}
