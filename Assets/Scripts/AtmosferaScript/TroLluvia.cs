using UnityEngine;
using System.Collections;

public class TroLluvia : MonoBehaviour {
	//Declaración de variables
	public GameObject goMentenTroLluvia;
	public ParticleSystem psLluvia;
	double  avisoMenten;

	void Start () {
	//	Physics.gravity = new Vector3(0f, 0f, 5f);
		//pausar el sistema de partículas en el inicio
		psLluvia.Pause();
	}
	void Update () {
		//capturar el indicador de eventos de la animación de Menten
		avisoMenten = goMentenTroLluvia.GetComponent<MentenEventos>().indicador;
		//la lluvia comienza en el tiempo especificado
		if (avisoMenten == 13) {
			psLluvia.Play ();
		}
		//La lluvia termina en el tiempo especificado
		if (avisoMenten == 17 ) {
			psLluvia.Stop ();
		}
	}
}


