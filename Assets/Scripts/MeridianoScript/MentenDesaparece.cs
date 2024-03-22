using UnityEngine;
using System.Collections;

public class MentenDesaparece : MonoBehaviour {
	//Definicion de variables
	public GameObject goSilla;
	public GameObject goTelescopio;
	public GameObject goJupiter;


	public void PadreDesaparece()
	{
		//El padre Menten desaparece y aparecen los objetos correspondientes
		goSilla.SetActive(true);
		goTelescopio.SetActive(true);
		goJupiter.SetActive(true);
		gameObject.SetActive(false);

	}
}
