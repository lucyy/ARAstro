using UnityEngine;
using System.Collections;

public class AgujeroControlMenten : MonoBehaviour {

	//Declaración de variables
	public AudioSource asMentenAgujero;
	public Animator atrMentenAgujero;
	public bool alarmaAgujero = false;

	void Update()
	{ 
		//si la animacion actual tiene el nombre de Descanso entonces el audio se detiene
		if (atrMentenAgujero.GetCurrentAnimatorStateInfo (0).IsName ("Descanso") && alarmaAgujero == false) {

			asMentenAgujero.Stop ();
			atrMentenAgujero.speed = 0;
			alarmaAgujero = true;
		}
	}

	/*
	//Función para reproducir el audio y para hacer que la animación se realice
	void TargetEncontrado()
	{
		asMentenAgujero.Play ();
		atrMentenAgujero.speed=1;
	}
	//Función para pausar el audio y para hacer que la animación también se pause
	void TargetPerdido()
	{
		asMentenAgujero.Pause ();
		atrMentenAgujero.speed=0;
	}
	*/
}
