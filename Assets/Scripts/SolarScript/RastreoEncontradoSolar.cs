using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RastreoEncontradoSolar : MonoBehaviour
{

    //Declaracion de variables
    public AudioSource asSolar;
    float contador;
    // Start is called before the first frame update
    void Start()
    {
        //Se pausa el audio
   //     asMentenSolar.Pause();
        //Se guarda la longitud del audio en segundos
        contador = asSolar.clip.length;

    }

    // Update is called once per frame
    void Update()
    {

      //  indicador = true;
        contador -= Time.deltaTime;


    
       // indicador = true;
     //   asSolar.Play();

    }

     public void TargetEncontrado()
    {
        asSolar.Play();
       // indicador = true;
        if (contador < 0)
        {
            asSolar.Stop();
        }
    }
}
