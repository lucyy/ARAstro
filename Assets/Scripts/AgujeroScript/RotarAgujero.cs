using UnityEngine;
using System.Collections;

public class RotarAgujero : MonoBehaviour {

	//Declaración de Variables
	public GameObject goTierra;
	public GameObject goLuna;
	public GameObject goSaturno;
    bool superficieS;
	bool superficieT;
	bool superficieL;
	float velocidad=10f;

	void Update () {

		//Rotación del Sprite Agujero Negro
		transform.Rotate (0,velocidad*Time.deltaTime,0);

		//Tomar el dato de los indicadores booleanos de los 3 cuerpos celestes, para verificar que el cuerpo celeste ya esté cerca del centro del Agujero
		superficieL = goLuna.GetComponent<MoverLuna> ().superficieL;
		superficieT = goTierra.GetComponent<MoverTierra> ().superficieT;
		superficieS = goSaturno.GetComponent<MoverSaturno> ().superficieS;

		//si se verifica que el cuerpo está cerca del centro del Agujero entonces vuelve a activarse la posibilidad de colisión y permite que haya choques
		if (superficieL|| superficieT|| superficieS  == true ) {
			
			(gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = false;
		}
	}		
		
	//Función que detecta las colisionan al cuerpo
	void OnCollisionEnter(Collision colisionAgujero)
	{
		//si colisiona un cuerpo entonces Is Trigger se activa y por lo tanto permite pasar a los cuerpos
		(gameObject.GetComponent(typeof(Collider)) as Collider).isTrigger = true;
	}
}

