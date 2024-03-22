using UnityEngine;
using System.Collections;

public class MoverLuna : MonoBehaviour {

	//Declaración de variables
	public Transform trmCentro;
	public bool superficieL=false;
	Rigidbody rbCuerpo;
	Vector3 posCuerpo;
	Ray rayRayo;
	RaycastHit ryhtToque;
	float fuerzaIzquierda=3f;
	float fuerzaAbajo=3f;
	float rotacion=3f;
	string nombre;
	bool colision=false;
	float velocidad = 5;
	float paso;
	bool tocado = false;

	void Start () {
		//obtención del Riridbody local
		rbCuerpo = this.GetComponent<Rigidbody>();
		paso= velocidad * Time.deltaTime; 
	}
		
	void FixedUpdate () {
		if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
		{
			//Se almacena el rayo generado desde el punto tocado en la pantalla
			rayRayo = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			//condición que es verdadera cuando el rayo interseca un collider, tiene como parámetro el rayo generado e información del objeto con el que colisionó
			if (Physics.Raycast(rayRayo, out ryhtToque))
			{
				//si existe colisión se guarda el nombre del objeto tocado por el rayo
				nombre = ryhtToque.rigidbody.name;
				//condición para verificar si el nombre del objeto tocado es Luna
				if (nombre == "Luna")
				{
					tocado = true;
				}
			}
		}

		if (tocado == true)
		{
			transform.position = Vector3.MoveTowards(transform.position, trmCentro.position, paso);

		}


		/*
		//condición para verificar que el toque sea realizado  con un solo dedo y esté en la fase inicial
	if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Began) {
			//Se almacena el rayo generado desde el punto tocado en la pantalla
			rayRayo = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			//condición que es verdadera cuando el rayo interseca un collider, tiene como parámetro el rayo generado e información del objeto con el que colisionó
				if (Physics.Raycast (rayRayo, out ryhtToque)) {
				//si existe colisión se guarda el nombre del objeto tocado por el rayo
					nombre = ryhtToque.rigidbody.name;
				//condición para verificar si el nombre del objeto tocado es Luna
						if (nombre == "Luna") {
					//se añade dos fuerzas al objeto una que va a su izquierda y la otra hacia abajo tipo impulso
							rbCuerpo.AddForce (Vector3.left * fuerzaIzquierda, ForceMode.Impulse);
							rbCuerpo.AddForce (Vector3.down * fuerzaAbajo, ForceMode.Impulse);
						}
					}
		}

	*/

		//condición que verifica si la colisión ocurrió
		if (colision == true) {  
			//la luna gira alrededor del Centro del Agujero, alrededor del eje Y con la velocidad de rotación especificada
			transform.RotateAround(trmCentro.position, Vector3.up, rotacion*Time.deltaTime);
			//se le añade fuerza hacia abajo a la luna
				rbCuerpo.AddForce (Vector3.down, ForceMode.Impulse);
			//condición que verifica que la ubicación en el eje Y de la luna sea menor a la posición del Centro del Agujero más 400
			if (transform.position.y < trmCentro.position.y+400f) {
				//con esta expresión se tiene el efecto de ir en espiral hacia abajo, se realiza una interpolación en cada eje coordenado, entre la posición actual y la posición del Centro del Agujero
				transform.position=new Vector3(Mathf.Lerp( transform.position.x, 
				trmCentro.position.x ,0.3f),Mathf.Lerp( transform.position.y, 
				trmCentro.position.y ,0.1f),Mathf.Lerp( transform.position.z, trmCentro.position.z ,0.3f));
			}
			//condición para definir si la posición en Y de luna es menor que la posición del centro del Agujero más uno
			if (transform.position.y < trmCentro.position.y+1f) {
				//el indicador booleano se vuelve verdadero
				superficieL = true;
				gameObject.SetActive(false);
			}
		}
	}
	//Función que permite detecta la colisión de la luna 
	void OnCollisionEnter(Collision colisionL)
	{
		//la variable booleana colision se hace verdadera
		colision = true;
	}
}
