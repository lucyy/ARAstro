using UnityEngine;
using System.Collections;
using System;

public class SismoControl : MonoBehaviour {

	//Declaracion de variables
	public AudioSource asMentenSismo;
	public GameObject goMentenSismo;
	Animator atrMentenSismo;
	public GameObject goGoneciat;
	public GameObject goBoshOmori;
	public GameObject goMaincaBosh;
	public GameObject goPlacaContinental;
	public bool alarmaSismo = false;

	void Start () {
		atrMentenSismo = goMentenSismo.GetComponent<Animator> ();
	}

	void Update () {

		if (atrMentenSismo.GetCurrentAnimatorStateInfo(0).IsName("Descanso") && alarmaSismo==false)
		{
			{
				asMentenSismo.Stop ();
				atrMentenSismo.speed = 0;
				alarmaSismo = true;
			}
		}
		if (!atrMentenSismo.GetCurrentAnimatorStateInfo (0).IsName ("Descanso")) {
			
			if (asMentenSismo.time > 9.1 && asMentenSismo.time < 9.3) {
				goMentenSismo.SetActive (false);
				goGoneciat.SetActive (true);
			}
			if (asMentenSismo.time > 17.1 && asMentenSismo.time < 17.4) {
				goGoneciat.SetActive (false);
				goBoshOmori.SetActive (true);
			}
			if (asMentenSismo.time > 22.1 && asMentenSismo.time < 22.4) {
				goBoshOmori.SetActive (false);
				goMaincaBosh.SetActive (true);
			}
			if (asMentenSismo.time > 28.1 && asMentenSismo.time < 28.4) {
				goMaincaBosh.SetActive (false);
				goMentenSismo.SetActive (true);
				atrMentenSismo.Play ("SismoAnimMenten2");
			}
			if (asMentenSismo.time > 81.1 && asMentenSismo.time < 81.4) {
				goMentenSismo.SetActive (false);
				goPlacaContinental.SetActive (true);
			}
			if (asMentenSismo.time > 90.1 && asMentenSismo.time < 90.4) {
				goPlacaContinental.SetActive (false);
				goMentenSismo.SetActive (true);
				atrMentenSismo.Play ("SismoAnimMenten3");
			}
		}
	}
	/*
	void TargetEncontrado()
	{
		asMentenSismo.Play ();
		atrMentenSismo.speed=1;
	}
	//Función para pausar el audio, que las animaciones de Menten y Pepe se pausen y que encontrarTarget sea falso cuando no se detecte el target
	void TargetPerdido()
	{
		asMentenSismo.Pause ();
		try
		{
			atrMentenSismo.speed=0;

		}
		catch(Exception) {

		}
	}
	*/
}
