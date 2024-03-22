using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargaEscenas : MonoBehaviour {

	//Declaracion de variables
	public GameObject goImagenFondo;
	public Slider slProgreso;
	public Text txTextoCarga;
	public Text txPorcentaje;
	public Image imPorcentaje;
	public Image imInstruccion;
	AsyncOperation aoCargar;
	int indicadorEscena;


	void Start () {
		//la orientacion de la pantalla se configura para que sea vertical en el munu principal
		Screen.orientation = ScreenOrientation.Portrait;
	}

	//metodos que se adjuntan a los botones para asignar un numero al indicadorEscena
	public void SaludoEscena()
	{
		indicadorEscena = 1;
	}

	public void AtmosferaEscena ()
	{
		indicadorEscena = 2;
	}

	public void SolarEscena() 
	{
		indicadorEscena = 3;
	}

	public void AgujeroEscena() 
	{
		indicadorEscena = 4;
	}
	public void Sismografos() 
	{
		indicadorEscena = 5;
	}
	public void MeridianoEscena()
	{
		indicadorEscena = 6;
	}
	public void Merz()
	{
		indicadorEscena = 7;
	}

	public void Url()
	{
		//direccionamiento a una pagina web en la que se encuentra la imagen del sistema solar
		Application.OpenURL("https://oaq.epn.edu.ec/arastro/sistemasolar.jpg");
	}
	//muestra las instrucciones de la aplicacion
	public void MostrarInstruccion()
	{
		imInstruccion.gameObject.SetActive(true);

	}
	//Oculta las instrucciones de la aplicacion
	public void OcultarInstruccion()
	{
		imInstruccion.gameObject.SetActive(false);

	}
	//Salir de la aplicacion
	public void Salir()
	{
		Application.Quit ();
	}
	public void CargarEscena()
	{

		//activa los elementos que muestran la interfaz de carga de la escena
		goImagenFondo.SetActive (true);
		slProgreso.gameObject.SetActive (true);
		txTextoCarga.gameObject.SetActive (true);
		txPorcentaje.gameObject.SetActive (true);
		imPorcentaje.gameObject.SetActive (true);

		//comienzo de la corrutina
		StartCoroutine (CargarNivel ());
	}

	//esta corrutina escoge la opcion elegida por el usuario mediante un switch para cargar la escena correspondiente en backgrond
	//mientras se carga se muestra un progress bar con el avance de carga de la escena
	IEnumerator CargarNivel()
	{
		yield return new WaitForSeconds(1);
		switch (indicadorEscena) 
		{
		case 1:
			aoCargar = SceneManager.LoadSceneAsync (1);
			break;
		case 2:
			aoCargar = SceneManager.LoadSceneAsync (2);
			break;
		case 3:
			aoCargar = SceneManager.LoadSceneAsync (3);
			break;
		case 4:
			aoCargar = SceneManager.LoadSceneAsync (4);
			break;
		case 5:
			aoCargar = SceneManager.LoadSceneAsync (5);
			break;
		case 6:
			aoCargar = SceneManager.LoadSceneAsync (6);
			break;
		case 7:
			aoCargar = SceneManager.LoadSceneAsync (7);
			break;
		}


		aoCargar.allowSceneActivation = false;
		//mientras la operacion asincronica de cargar la escena no termine de realizarse no se muestra la escena
		while (!aoCargar.isDone) {
			//en el valor del slider se ve reflejado el progreso de la carga de escena
			slProgreso.value = aoCargar.progress;
			//se muestra en el numero de la pantalla el porcentaje de carga redondeado, sin decimales.
			txPorcentaje.text = Mathf.Round((aoCargar.progress * 100)).ToString();
			//cuando el porcentaje de carga llega a 90% entonces se activa la vision de la escena
			if(aoCargar.progress==0.9f)
			{	
				aoCargar.allowSceneActivation = true;
			}
			//se retorna al siguiente frame, de este modo se puede mirar el avance del progress bar
		yield return null;
		}
	}
}




