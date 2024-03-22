using UnityEngine;
using System.Collections;

public class ControlAudio : MonoBehaviour {

	//Declaracion de variables
	public	AudioSource asSolar;
	float contador;
	bool indicador;

	void Start () {
		//Se pausa el audio
		asSolar.Pause ();
		//Se guarda la longitud del audio en segundos
		contador = asSolar.clip.length;
	}

	void Update () {
		//miestras el audio se reproduzca disminuir en uno el tiempo en segundos de su reproduccion
		if (indicador == true) {
			contador -= Time.deltaTime;
		}
	}
	//funcion para reproducir el audio miestras el target es detectado y si el tiempo de reproduccion termina, se detiene
	void TargetEncontrado()
	{
		asSolar.Play();
		indicador = true;
		if (contador<0) 
		{
			asSolar.Stop ();
		}
	}
	//funcion para no reproducir el audio miestras el target no es detectado 
	void TargetPerdido()
	{
		asSolar.Pause ();
	}
}
