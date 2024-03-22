using UnityEngine;
using System.Collections;

public class IonOndaRadio2 : MonoBehaviour {

	//Declaración de variables
	public GameObject goMentenOnda2;
	public GameObject goControlOnda2;
	Vector3 posicionInicial;
	float velocidad=6f;
	double  avisoMenten;
	bool targetPresente;

	void Start () {
		posicionInicial = transform.position;
	}

	void Update () {
		//Capturar los indicadores de las variables para detectar al target y el indocador de eventos de la animación de Menten
		avisoMenten = goMentenOnda2.GetComponent<MentenEventos> ().indicador;
		//targetPresente = goControlOnda2.GetComponent<ControlCapas> ().presenciaTarget;

		//si el target es detectado el Rayo 2 se traslada o se detiene dependiendo de avisoMenten, es decir del evento asociado 
	//if (targetPresente == true) {
		if (avisoMenten==37.25 || avisoMenten==40.10) {
		
				transform.Translate (velocidad*Vector3.up*Time.deltaTime);
		}
		if (avisoMenten==41.30) {

			transform.Translate (Vector3.zero);
		//	transform.position = posicionInicial;
		}
		if (avisoMenten==43.25 || avisoMenten==46.10) {

			//	transform.Translate (velocidad*Vector3.up*Time.deltaTime);
		}
		if (avisoMenten==47.30) {
		//	this.gameObject.SetActive(false);
		//	Destroy(gameObject);
		//	transform.Translate (Vector3.zero);
		//	transform.position = posicionInicial;
		
		}
	//	}
	}
}
