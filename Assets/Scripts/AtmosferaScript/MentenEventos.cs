using UnityEngine;
using System.Collections;

public class MentenEventos : MonoBehaviour {

	//declaración de la variable que servirá como indicador en cada uno de los eventos
	public double indicador=0;

	//Eventos relacionados con cada una de las capas asociados a la animación de Menten
	//Eventos de la Capa Tropósfera la Lluvia
	public void LluviaComienza()
	{
		indicador = 13;
	}
		
	public void LluviaTermina()
	{
		indicador = 17;
	}

	//Eventos Aparición y desaparición de capas
	public void TroposferaDesaparece()
	{
		indicador = 18;
	}

	public void EstratosferaDesaparece()
	{
		indicador = 25;
	}
	public void MesosferaDesaparece()
	{
		indicador = 34;
	}

	public void IonosferaDesaparece()
	{
		indicador = 49;
	}
	public void ExosferaDesaparece()
	{
		indicador = 54;
	}
		
	//Eventos de la Capa Mesósfera del Meteorito
	public void DesactivarMeteoro1()
	{
		indicador = 26.48;
	}

	public void FinInstanciaG1()
	{
		indicador = 27;
	}

	public void DesactivarMeteoro2()
	{
		indicador = 27.36;
	}
	public void FinInstanciaG2()
	{
		indicador = 27.48;
	}

	public void DesactivarMeteoro3()
	{
		indicador = 28.24;
	}
	public void FinInstanciaG3()
	{
		indicador = 28.36;
	}
	public void DesactivarMeteoro4()
	{
		indicador = 29.12;
	}
		
	public void FinInstanciaG4()
	{
		indicador = 29.24;
	}

	public void DesactivarMeteoro5()
	{
		indicador = 30;
	}

	public void FinInstanciaG5()
	{
		indicador = 30.12;
	}
	public void EstrellaPequena()
	{
		indicador = 31;
	}

	public void DesactivarMeteoro6()
	{
		indicador = 32.30;
	}
	public void DestruccionMeteoros()
	{
		indicador = 33.30;
	}


	//Eventos de la Capa Ionósfera Rayo1
	public void TrasladoR1()
	{
		indicador = 36;
	}
	public void DetenerseR1()
	{
		indicador = 40.10;
	}
		
	public void PosicionInicialR1()
	{
		indicador = 41.45;
	}

	public void Traslado2R1()
	{
		indicador = 42;
	}

	public void Detenerse2R1()
	{
		indicador = 46.10;
	}

	//Eventos de la Capa Ionósfera Rayo2
	public void TrasladoR2()
	{
		indicador = 37.25;
	}

	public void DetenerseR2()
	{
		indicador = 41.30;
	}
	public void Traslado2R2()
	{
		indicador = 43.25;
	}
	public void Detenerse2R2()
	{
		indicador = 47.30;
	}
}
