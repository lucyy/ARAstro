using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;

public class TocarCuerpo : MonoBehaviour
{

	//Declaracion de variables

	public TextMesh txmTexto1;
	public TextMesh txmTexto2;
	public TextMesh txmTexto3;

	ArrayList arlCuerpos;
	Vector3 posicion;

	CuerpoCeleste cuerpoSol;
	CuerpoCeleste cuerpoMer;
	CuerpoCeleste cuerpoVen;
	CuerpoCeleste cuerpoTie;
	CuerpoCeleste cuerpoMar;
	CuerpoCeleste cuerpoJup;
	CuerpoCeleste cuerpoSat;
	CuerpoCeleste cuerpoUra;
	CuerpoCeleste cuerpoNep;
	CuerpoCeleste cuerpoLun;
	CuerpoCeleste cuerpoDei;
	CuerpoCeleste cuerpoPho;
	CuerpoCeleste cuerpoCal;
	CuerpoCeleste cuerpoGan;
	CuerpoCeleste cuerpoTitan;
	CuerpoCeleste cuerpoTit;
	CuerpoCeleste cuerpoObe;
	CuerpoCeleste cuerpoTri;
	CuerpoCeleste cuerpoTemporal;

	Ray rayo;
	RaycastHit toque;

	string nombreCuerpo;
	string nombreTocado;


	void Start()
	{
		//creacion de un arraylist para guardar los objetos de la Clase CuerpoCeleste
		arlCuerpos = new ArrayList();
		//Creacion de los objetos de Clase CuerpoCeleste con tres parametros
		cuerpoSol = new CuerpoCeleste("Sol", "695.500 Km");
		cuerpoMer = new CuerpoCeleste("Mercurio", "2.440 Km", "88 días");
		cuerpoVen = new CuerpoCeleste("Venus", "6.052 Km", "225 días");
		cuerpoTie = new CuerpoCeleste("Tierra", "6.378 Km", "365 días");
		cuerpoMar = new CuerpoCeleste("Marte", "3.397 Km", "1 año 322 días");
		cuerpoJup = new CuerpoCeleste("Júpiter", "71.492 Km", "11 años 314 días");
		cuerpoSat = new CuerpoCeleste("Saturno", "60.268 Km", "29 años 168 días");
		cuerpoUra = new CuerpoCeleste("Urano", "25.559 Km", "84 años 4 días");
		cuerpoNep = new CuerpoCeleste("Neptuno", "24.764 Km", "164 años 298 días");
		//Creacion de los objetos de Clase CuerpoCeleste con dos parametros
		cuerpoLun = new CuerpoCeleste("Luna", "1.737,4 Km");
		cuerpoDei = new CuerpoCeleste("Deimos", "6,2 Km");//marte
		cuerpoPho = new CuerpoCeleste("Phobos", "11,4 Km");//marte
		cuerpoCal = new CuerpoCeleste("Callisto", "2.410 Km");//júpiter
		cuerpoGan = new CuerpoCeleste("Ganímides", "2.631 Km");//júpiter
		cuerpoTitan = new CuerpoCeleste("Titán", "2.575 Km");//saturno
		cuerpoTit = new CuerpoCeleste("Titania", "2.575 Km");//urano
		cuerpoObe = new CuerpoCeleste("Oberon", "761,4 Km"); //urano
		cuerpoTri = new CuerpoCeleste("Tritón", "1.353,4 Km");//neptuno
		cuerpoTemporal = new CuerpoCeleste("", "", "");
		//Se incluye a cada uno de los objetos en el arraylist
		arlCuerpos.Add(cuerpoSol);
		arlCuerpos.Add(cuerpoMer);
		arlCuerpos.Add(cuerpoVen);
		arlCuerpos.Add(cuerpoTie);
		arlCuerpos.Add(cuerpoMar);
		arlCuerpos.Add(cuerpoJup);
		arlCuerpos.Add(cuerpoSat);
		arlCuerpos.Add(cuerpoUra);
		arlCuerpos.Add(cuerpoNep);
		arlCuerpos.Add(cuerpoLun);
		arlCuerpos.Add(cuerpoDei);
		arlCuerpos.Add(cuerpoPho);
		arlCuerpos.Add(cuerpoCal);
		arlCuerpos.Add(cuerpoGan);
		arlCuerpos.Add(cuerpoTitan);
		arlCuerpos.Add(cuerpoTit);
		arlCuerpos.Add(cuerpoObe);
		arlCuerpos.Add(cuerpoTri);
	}

	void Update()
	{
		if (Input.touchCount > 0)
		{
			//Creacion de un rayo que va desde la posicion del toque en la pantalla
			rayo = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

			if (Physics.Raycast(rayo, out toque))
			{
				//Guarda el nombre del objeto tocado
				nombreTocado = toque.collider.gameObject.name;
				//Busca el nombre del cuerpo tocado en los objetos guardados en el arraylist
				foreach (CuerpoCeleste buscarCuerpo in arlCuerpos)
				{
					cuerpoTemporal = buscarCuerpo;
					//condicion para verificar el nombre del cuerpo tocado con el nombre de algun cuerpo que coincida de los cuerpos guardados
					if (cuerpoTemporal.Nombre() == nombreTocado)
					{
						//si la condicion se cumple se imprime en el texto 3d el nombre, el radio y el dia solar en caso de haber esta informacion en el objeto, en caso de no haber no se imprime nada
						txmTexto1.text = cuerpoTemporal.Nombre();
						txmTexto2.text = cuerpoTemporal.Radio();
						if (cuerpoTemporal.DiaSolar() == null)
						{
							txmTexto3.text = "";
						}
						else
						{
							txmTexto3.text = cuerpoTemporal.DiaSolar();
						}
					}
				}
			}
		}
	}
}
