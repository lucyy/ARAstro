using UnityEngine;
using System.Collections;

public class MesMeteoro : MonoBehaviour {
	//Declaración de variables
	public GameObject goMentenMesMeteoro;
	public GameObject goMeteoro1;
	public GameObject goMeteoro2;
	public GameObject goMeteoro3;
	public GameObject goMeteoro4;
	public GameObject goMeteoro5;
	public GameObject goMeteoro6;
	public GameObject goPiedra;
	public GameObject goPiedra2;
	GameObject [] goMeteorosPequenos;
	GameObject[] clon=new GameObject[1500];
	public GameObject goControlMesMeteoro;

	bool targetPresente;
	double  avisoMenten;
	int i=0;
	float x;
	float y;
	float z;
	Vector3 posicionInicialPiedra;
	float zPiedra1;
	float zPiedra2;
	float zPiedra;

	float escala1 = 0.5f;
	float escala2 = 0.5f;
	float escala3 = 0.5f;

	void Start()
	{
		posicionInicialPiedra = goPiedra.transform.position;
		zPiedra1 = posicionInicialPiedra.z + 14f;
		zPiedra2 = posicionInicialPiedra.z +2f;
		//zPiedra = Random.Range(zPiedra1, zPiedra2);
	}
	void Update () {
		//Captura los indicadores de las variables para detectar al target y el indicador de eventos de la animación de Menten
	//	targetPresente= goControlMesMeteoro.GetComponent<ControlCapas> ().presenciaTarget;
		avisoMenten = goMentenMesMeteoro.GetComponent<MentenEventos> ().indicador;

		//El Meteoro Total se mueve miestras transcurren todos los eventos
		if (avisoMenten > 26 ){// && targetPresente==true) {
			transform.Translate (new Vector3 (7f, 3f, 0) * Time.deltaTime);
		}
		//condiciones para verificar el valor de aviso menten y desaparecer las partes del meteoro para ser reemplazadas por un conjunto de meteoros pequeños
		if (avisoMenten == 26.48) {
			
			goMeteoro1.SetActive (false);
		
			x = Random.Range (posicionInicialPiedra.x, posicionInicialPiedra.x-10f);
			y = Random.Range (posicionInicialPiedra.y+6f , posicionInicialPiedra.y-4f);
			z = Random.Range(zPiedra1, zPiedra2) ; 

			InstanciarMeteoros (x, y, z, escala1, escala2, escala3);
		}
		if (avisoMenten == 27.36) {
			
			goMeteoro2.SetActive (false);

			x = Random.Range(posicionInicialPiedra.x, posicionInicialPiedra.x+10f);
			y = Random.Range(posicionInicialPiedra.y +2f, posicionInicialPiedra.y-8f);
			z = Random.Range(zPiedra1, zPiedra2);
			InstanciarMeteoros (x, y, z, escala1, escala2, escala3);
		}
		if (avisoMenten == 28.24) {
			
			goMeteoro3.SetActive (false);

			x = Random.Range(posicionInicialPiedra.x + 8f, posicionInicialPiedra.x+18f);
			y = Random.Range(posicionInicialPiedra.y - 2f, posicionInicialPiedra.y-12f);
			z = Random.Range(zPiedra1, zPiedra2);
			InstanciarMeteoros(x, y, z, escala1, escala2, escala3);
		}
		if (avisoMenten == 29.12) {
			
			goMeteoro4.SetActive (false);

			x = Random.Range(posicionInicialPiedra.x + 12f, posicionInicialPiedra.x+22f);
			y = Random.Range(posicionInicialPiedra.y-4f , posicionInicialPiedra.y-14f);
			z = Random.Range(zPiedra1, zPiedra2);
			InstanciarMeteoros (x, y, z, escala1, escala2, escala3);
		}
		if (avisoMenten == 30) {
			
			goMeteoro5.SetActive (false);

			x = Random.Range(posicionInicialPiedra.x + 16f, posicionInicialPiedra.x+28f);
			y = Random.Range(posicionInicialPiedra.y - 8f, posicionInicialPiedra.y-18f);
			z = Random.Range(zPiedra1, zPiedra2);
			InstanciarMeteoros (x, y, z, escala1, escala2, escala3);
		}
		if (avisoMenten == 32.30) {

			goMeteoro6.SetActive (false);
		}
		if (avisoMenten == 33.30) {
			
			goMeteorosPequenos = GameObject.FindGameObjectsWithTag ("tagMeteoro");
			//encuentra y destruye los objetos Meteoro clonados
			foreach (GameObject desaparece in goMeteorosPequenos) {
				Destroy (desaparece);
			}
		}
	}			

	//Función para clonar los pedazos de Meteoro
	void InstanciarMeteoros(float z, float w, float a, float escala1, float escala2, float escala3)
	{
		//as GameObject expresion explicita y especifica para casting de un object a un GameObject
		//clonacion del objeto piedra
		clon[i]=Instantiate (goPiedra, new Vector3 (z, w, a), transform.rotation) as GameObject;
		//Ponerles una etiqueta para que en la destrucción puedan ser identificados
		clon [i].gameObject.tag = "tagMeteoro";
		//Especificar su escala
		clon [i].transform.localScale = new Vector3(escala1, escala2, escala3);
		//sumar en uni para crear el siguiente objeto
	//	clon[i].gameObject.transform.SetParent(goPiedra2.transform);
		i++;
	}
}








