using UnityEngine;
using System.Collections;

public class ControlMentenAstronomo : MonoBehaviour {

	//Declaración de variables
    public AudioSource asMentenMeridiano;
	public Animator atrMentenMeridiano;
	public bool alarmaMeridiano = false;
	//public bool encontrarTarget=false;

	void Update()
	{
		//si la animacion actual tiene el nombre de Descanso entonces el audio se detiene
		if (atrMentenMeridiano.GetCurrentAnimatorStateInfo (0).IsName ("Descanso") && alarmaMeridiano == false) {
		
			asMentenMeridiano.Stop ();
			atrMentenMeridiano.speed = 0;
			alarmaMeridiano = true;
		}
	}
	/*
	//Función para reproducir el audio, que las animaciones de Menten y Pepe se desarrollen y que encontrarTarget sea verdad cuando se detecte el target
	void TargetEncontrado()
	{
		asMentenMeridiano.Play ();
		atrMentenMeridiano.speed=1;
		encontrarTarget = true;

	}
	//Función para pausar el audio, que las animaciones de Menten y Pepe se pausen y que encontrarTarget sea falso cuando no se detecte el target
	void TargetPerdido()
	{
		asMentenMeridiano.Pause ();
		atrMentenMeridiano.speed=0;
		encontrarTarget = false;
	}
	*/
}
