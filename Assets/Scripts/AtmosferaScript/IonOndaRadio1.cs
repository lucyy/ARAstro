using UnityEngine;
using System.Collections;

public class IonOndaRadio1 : MonoBehaviour {

	//Declaración de variables
	public GameObject goMentenOnda1;
	public GameObject goControlOnda1;
	Vector3 posicionInicial;
	float velocidad=6f;
	double  avisoMenten;
	bool targetPresente;

	void Start () {
		posicionInicial = transform.position;
	}

	void Update () {
		//Captura los indicadores de las variables para detectar al target y el indocador de eventos de la animación de Menten
		avisoMenten = goMentenOnda1.GetComponent<MentenEventos> ().indicador;
		//targetPresente = goControlOnda1.GetComponent<ControlCapas> ().presenciaTarget;

		//si el target es detectado el Rayo 1 se traslada o se detiene dependiendo de avisoMenten, es decir del evento asociado 
	//	if (targetPresente == true) {

			if (avisoMenten==36 || avisoMenten==37.25) {
				transform.Translate (velocidad*Vector3.up*Time.deltaTime);
		}
			if (avisoMenten==40.10) {
			transform.Translate (Vector3.zero);
		}
			if (avisoMenten==41.45) {
			
		//	transform.position = posicionInicial;
		}
			if (avisoMenten==42 || avisoMenten==43.25) {

			//	transform.Translate (velocidad*Vector3.up*Time.deltaTime);
		}
		if (avisoMenten==46.10) {
		//	this.gameObject.SetActive(false);
			//transform.Translate (Vector3.zero);
			//Destroy(this);
		}
	//	}
	}
}
