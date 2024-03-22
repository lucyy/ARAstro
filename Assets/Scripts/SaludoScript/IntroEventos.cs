using UnityEngine;
using System.Collections;

public class IntroEventos : MonoBehaviour {
	//Declaracion de variables
	public AudioSource asMentenIntro;
	public Animator atrMentenIntro;
	public GameObject goOaqAntiguo;
	public GameObject goBonn;
	public GameObject goPlanoQuito;
	public GameObject goBosh;
	public GameObject goEstacion;
	public GameObject goDrLopez;
	public GameObject goOaq;
	public bool alarmaIntro = false;

	void Start () {
	//En el inicio los GameObject son desactivados para ser activados de acuerdo al diallogo
	//	goBonn.SetActive(false);
	//	goPlanoQuito.SetActive (false);
	//	goBosh.SetActive(false);
	//	goEstacion.SetActive (false);
	//	goDrLopez.SetActive(false);
	//	goOaq.SetActive (false);
	}

	void Update ()
	{   //si la animacion actual tiene el nombre de descanso entonces el audio se para 
		if (atrMentenIntro.GetCurrentAnimatorStateInfo (0).IsName ("Descanso") && alarmaIntro == false) {
			asMentenIntro.Stop ();
			atrMentenIntro.speed = 0;
			alarmaIntro = true;
		}
	}

	//Metodos para mostrar u ocultar las imagenes segun corresponda
	public void ApareceBonn ()
	{
		goOaqAntiguo.SetActive (false);
		goBonn.SetActive (true);
	}
	public void AparecePlanoQuito ()
	{
		goBonn.SetActive (false);
		goPlanoQuito.SetActive (true);
	}
	public void ApareceBosh()
	{
		goPlanoQuito.SetActive (false);
		goBosh.SetActive (true);
	}
	public void ApareceEstacion ()
	{
		goBosh.SetActive (false);
		goEstacion.SetActive (true);
	}
	public void ApareceDrLopez ()
	{
		goEstacion.SetActive (false);
		goDrLopez.SetActive (true);
	}
	public void ApareceOaq ()
	{
		goDrLopez.SetActive (false);
		goOaq.SetActive (true);
	}

	void TargetEncontrado()
	{
		asMentenIntro.Play ();
		atrMentenIntro.speed = 1;
	}

	void TargetPerdido ()
	{
		asMentenIntro.Pause ();
		atrMentenIntro.speed = 0;
	}
}
