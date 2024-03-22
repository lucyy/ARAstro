using UnityEngine;
using System.Collections;

public class MovimientoSillaTelescopio : MonoBehaviour {

	//Declaracion de variables
	public GameObject goMentenMeridiano;
	public GameObject goControladorMP;
	public GameObject goSilla;
	public GameObject goTelescopio;
	public GameObject goPlaneta;
	//bool encontrarTarget=false;
	float velocidadTeles=0;
	float velocidadSilla=0;
	float velocidadRotarSilla=0;

	void Update () {

		//Se captura la variable tomada del script ControlMentenPepe, para detectar el target
	//	this.encontrarTarget =goControladorMP.GetComponent<ControlMentenAstronomo> ().encontrarTarget;

		//condicion para verificar que el target fue detectado
	//	if (encontrarTarget == true) {

			//si el target es detectado  el telescopio y la sila rotan o se trasladan, dependiendo de los eventos vinculados con la animacion de Pepe
			goTelescopio.transform.Rotate (new Vector3 (0,0,velocidadTeles)*Time.deltaTime);
			goSilla.transform.Translate (velocidadSilla * Time.deltaTime, 0, 0);
			goSilla.transform.Rotate (new Vector3 (0,velocidadRotarSilla,0)*Time.deltaTime);
	
	//	}
		}

	//Eventos vinculados con la animacion de Pepe, se activan en los tiempos especificados en la animacion,  y representa la velocidad a la que debe rotar o trasladar el elemento especificado en el nombre de la funcion
	public void MoverTelescopio()
	{
		velocidadTeles = 20f;
	}
	public void MoverTelescopio2()
	{
		velocidadTeles = 17f;
	}
	public void MoverTelescopio3()
	{
		velocidadTeles = 32f;
	}
	public void MoverTelescopio4()
	{
		velocidadTeles = 22f;
	}
	public void PararTelescopio()
	{
		velocidadTeles = 0f;
	}
	public void MoverSilla()
	{
		velocidadSilla = 170f;
	}
	public void MoverSilla2()
	{
		velocidadSilla = 350f;
	}
	public void PararSilla()
	{
		velocidadSilla = 0f;
	}
	public void RotarSilla()
	{
		velocidadRotarSilla = 180f;
	}
	public void PararRotarSilla()
	{
		velocidadRotarSilla = 0f;
	}
	public void AparecePadre()
	{
		//cuando en padre Menten aparece, los elementos 3d desaparecen 
		goPlaneta.SetActive (false);
		goSilla.SetActive (false);
		goTelescopio.SetActive (false);
		goMentenMeridiano.SetActive (true);
		//se activa la animacion de Menten correspondiente
		goMentenMeridiano.GetComponent<Animator> ().Play ("TManimMenten2");
	}
}
