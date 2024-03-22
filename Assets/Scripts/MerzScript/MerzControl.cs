using UnityEngine;
using System.Collections;
using System;

public class MerzControl : MonoBehaviour {

	public AudioSource asMentenMerz;
	Animator atrMentenMerz;
	public GameObject goMentenMerz;
	public GameObject goPlaca;
	public GameObject goJuegoLentes;
	public GameObject goEjeHorario;
	public GameObject goEjeDeclinacion;
	public GameObject goRelojeria;
	public GameObject goCupula;
	public GameObject goRieles;
	public GameObject goCompuertaLateral1;
	public GameObject goCompuertaLateral2;
	public GameObject goCompuertaTecho;
	public bool alarmaMerz = false;
	// Use this for initialization
	void Start () {
		atrMentenMerz = goMentenMerz.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (atrMentenMerz.GetCurrentAnimatorStateInfo(0).IsName("Descanso"))
		{
			{
				asMentenMerz.Stop ();
				atrMentenMerz.speed = 0;
				alarmaMerz = true;
			}
		}

		if (!atrMentenMerz.GetCurrentAnimatorStateInfo (0).IsName ("Descanso")) {
			
			if (asMentenMerz.time > 23.1 && asMentenMerz.time < 23.4) {
				goMentenMerz.SetActive (false);
				goPlaca.SetActive (true);
			}
			if (asMentenMerz.time > 28.1 && asMentenMerz.time < 28.4) {
				goPlaca.SetActive (false);
				goMentenMerz.SetActive (true);
				atrMentenMerz.Play ("MerzAnimMenten2");
			}
			if (asMentenMerz.time > 62.1 && asMentenMerz.time < 62.4) {
				goMentenMerz.SetActive (false);
				goJuegoLentes.SetActive (true);
			}
			if (asMentenMerz.time > 66.1 && asMentenMerz.time < 66.4) {
				goJuegoLentes.SetActive (false);
				goMentenMerz.SetActive (true);
				atrMentenMerz.Play ("MerzAnimMenten3");
			}
			if (asMentenMerz.time > 80.1 && asMentenMerz.time < 80.4) {
				goMentenMerz.SetActive (false);
				goEjeHorario.SetActive (true);
			}
			if (asMentenMerz.time > 102.1 && asMentenMerz.time < 102.4) {
				goEjeHorario.SetActive (false);
				goEjeDeclinacion.SetActive (true);
			}
			if (asMentenMerz.time > 110.1 && asMentenMerz.time < 110.4) {
				goEjeDeclinacion.SetActive (false);
				goMentenMerz.SetActive (true);
				atrMentenMerz.Play ("MerzAnimMenten4");
			}
			if (asMentenMerz.time > 122.1 && asMentenMerz.time < 122.4) {
				goMentenMerz.SetActive (false);
				goRelojeria.SetActive (true);
			}
			if (asMentenMerz.time > 127.1 && asMentenMerz.time < 127.7) {
				goRelojeria.SetActive (false);
				goCupula.SetActive (true);

			}
			if (asMentenMerz.time > 138.1 && asMentenMerz.time < 138.4) {
				goCupula.SetActive (false);
				goRieles.SetActive (true);
			}
			if (asMentenMerz.time > 144.5 && asMentenMerz.time < 144.9) {
				goRieles.SetActive (false);
				goCompuertaLateral1.SetActive (true);
				goCompuertaLateral2.SetActive (true);
			}
			if (asMentenMerz.time > 147.1 && asMentenMerz.time < 147.7) {
				goCompuertaLateral1.SetActive (false);
				goCompuertaLateral2.SetActive (false);
				goCompuertaTecho.SetActive (true);
			}
			if (asMentenMerz.time > 154.1 && asMentenMerz.time < 154.4) {
				goCompuertaTecho.SetActive (false);
				goMentenMerz.SetActive (true);
				atrMentenMerz.Play ("MerzAnimMenten5");
			}

		}
	}

/*
void TargetEncontrado()
	{
		asMentenMerz.Play ();
		atrMentenMerz.speed=1;

	}
	//Función para pausar el audio, que las animaciones de Menten y Pepe se pausen y que encontrarTarget sea falso cuando no se detecte el target
	void TargetPerdido()
	{
		asMentenMerz.Pause ();
		try

		{
			atrMentenMerz.speed=0;

		}
		catch(Exception) {
		
		}

	}
*/
}
