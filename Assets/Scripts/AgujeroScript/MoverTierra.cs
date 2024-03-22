using UnityEngine;
using System.Collections;

public class MoverTierra : MonoBehaviour {

	//Declaración de variables
	public Transform centro;
	public bool superficieT=false;
	Rigidbody rbCuerpo;
	Vector3 posCuerpo;
	Ray rayRayo;
	RaycastHit ryhtToque;
	float fuerzaAdelante=5f;
	float fuerzaAbajo=5f;
	float rotacion=3f;
	string nombre;
	bool colision=false;
	float velocidad = 5;
	float paso;
	bool tocado = false;

	void Start () {
		//obtención del Riridbody local
		rbCuerpo = this.GetComponent<Rigidbody>();
		paso = velocidad * Time.deltaTime;
	}

	void FixedUpdate () {
	
		
		//condición para verificar que el toque sea realizado  con un solo dedo y esté en la fase inicial
		if (Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Began) {
				//Se almacena el rayo generado desde el punto tocado en la pantalla
					rayRayo = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
				//condición que es verdadera cuando el rayo interseca un collider, tiene como parámetro el rayo generado y también información del objeto con el que colisionó dentro de la variable toque
				if (Physics.Raycast (rayRayo, out ryhtToque)) {
					//si existe colisión se guarda el nombre del objeto tocado por el rayo
					nombre = ryhtToque.rigidbody.name;
					//condición para verificar si el nombre del objeto tocado es Tierra
						if (nombre == "Tierra") {
					tocado = true;
				}
			}
		}

		if (tocado == true)
		{
			transform.position = Vector3.MoveTowards(transform.position, centro.position, paso);

		}

		//condición que verifica si la colisión ocurrió
		if (colision == true) {  
			// la Tierra gira alrededor del Centro del Agujero, alrededor del eje Y con la velocidad de rotación especificada
			transform.RotateAround(centro.position, Vector3.up, rotacion*Time.deltaTime);
			//se le añade fuerza hacia abajo a la Tierra
			rbCuerpo.AddForce (Vector3.down, ForceMode.Impulse);
			//condición que verifica que la ubicación en Y de la luna sea menor a la posición del Centro del Agujero más 400
			if (transform.position.y < centro.position.y+400f) {
				//con esta expresión se tiene el efecto de ir en espiral hacia abajo, se realiza una interpolación en cada eje coordenado, entre la posición actual y la posición del Centro del Agujero
				transform.position=new Vector3(Mathf.Lerp( transform.position.x, centro.position.x ,0.3f),Mathf.Lerp( transform.position.y, centro.position.y ,0.1f),Mathf.Lerp( transform.position.z, centro.position.z ,0.3f));
			}


			
			//condición para definir si la posición en Y de la Tierra es menor que la posición del centro del Agujero más uno
			if (transform.position.y < centro.position.y+1f) {
				//el indicador booleano se vuelve verdadero
				superficieT = true;
				gameObject.SetActive(false);
			}
			
		}

	}
	//Función que permite detecta la colisión de Saturno
	void OnCollisionEnter(Collision colisionT)
	{
		//la variable booleana colisión se hace verdadera
		colision = true;
	}
}
