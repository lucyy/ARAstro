using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControlCapas : MonoBehaviour {

	//Declaración de variables
	public GameObject goTroposfera;
	public GameObject goEstratosfera;
	public GameObject goMesosfera;
	public GameObject goIonosfera;
	public GameObject goExosfera;
	public GameObject goMentenAtmosfera;
	public GameObject goOnda1;
	public GameObject goOnda2;

	//public bool presenciaTarget=false;

	public AudioSource asMentenAtmosfera;
	public Animator atrMentenAtmosfera;

	double  indicadorEventos;

	public bool alarmaAtmos = false;

	// Use this for initialization
	void Start () {

		goEstratosfera.SetActive (false);
		goMesosfera.SetActive (false);
		goIonosfera.SetActive (false);
		goExosfera.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (atrMentenAtmosfera.GetCurrentAnimatorStateInfo(0).IsName("Descanso") && alarmaAtmos==false)
	{
			
				asMentenAtmosfera.Stop ();
				atrMentenAtmosfera.speed = 0;
				alarmaAtmos = true;
			
		}
		//Tomar la variable indicador de Eventos de la animación de Menten desde el GameObject Menten
		indicadorEventos= goMentenAtmosfera.GetComponent<MentenEventos> ().indicador;
		//Llamatr  a la función Eventos
		Eventos ();
	}

	//Funcion Ejecutada desde el Script Default Trackable Event Handler
	
	/*
	void TargetEncontrado()
	{
		//hacer verdadera la deteccción del target, reproducir el Audio Source, y que la velocidad de animator para la animaión sea normal
		presenciaTarget = true;
		asMentenAtmosfera.Play ();
		atrMentenAtmosfera.speed = 1;

	}
	//hacer falsala deteccción del target,pausar el Audio Source, y que la velocidad de animator para la animaión sea nula es decir la animación esté en pausa
	void TargetPerdido()
	{
		presenciaTarget = false;
		asMentenAtmosfera.Pause ();
		atrMentenAtmosfera.speed = 0;
	}

	*/
	 //Función Eventos
	void Eventos()
	{
		//Condiciones para detectar el valor del indicador de eventos según el transcurso de la animación, vinculado con el equivalente en segundos, para activar o desactivar los objetos y su jerarquía correspondiente
		if ( indicadorEventos == 18) {
			
			goTroposfera.SetActive (false);
			goEstratosfera.SetActive (true);
		}
		if ( indicadorEventos == 25) {

			goEstratosfera.SetActive (false);
			goMesosfera.SetActive (true);
		}

		if ( indicadorEventos == 34) {

			goMesosfera.SetActive (false);
			goIonosfera.SetActive (true);
		}
		if (indicadorEventos == 43)
		{
			goOnda1.SetActive(false);
			goOnda2.SetActive(false);

		}
		if ( indicadorEventos == 49) {

			goIonosfera.SetActive (false);
			goExosfera.SetActive (true);
		}
		if ( indicadorEventos == 54) {

		//	asMentenAtmosfera.Stop ();
		}

	}
}
