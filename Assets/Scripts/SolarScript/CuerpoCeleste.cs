using UnityEngine;
using System.Collections;

public class CuerpoCeleste: MonoBehaviour {
	//Declaracion de variables
	string nombre;
	string radio;
	string diaSolar;
	//Definicion del constructor con tres parametros de tipo string
	public CuerpoCeleste (string nombre, string radio, string diaSolar)
	{
		//asignacion de las variables de entrada a las variables locales
		this.nombre = nombre;
		this.radio = radio;
		this.diaSolar = diaSolar;
	
	}
	//Sobrecarga del constructor con dos parametros del tipo string
	public CuerpoCeleste (string nombre, string radio)
	{
		//asignacion de las variables de entrada a las variables locales
		this.nombre = nombre;
		this.radio = radio;
	}
	//Metodo que retorna el Nombre
	public string Nombre()
	{
		return nombre;
	}
	//Metodo que retorna en Radio
	public string Radio()
	{
		return radio;
	}
	//Metodo que retorna el tiempo que se demora en dar una vuelta alrededor del sol
	public string DiaSolar()
	{
		return diaSolar;
	}
}
