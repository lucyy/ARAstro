using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RastreoEncontradoAtmos : MonoBehaviour
{

    public AudioSource asAtmosfera;
    public Animator atrMentenAtmosfera;
     public GameObject goControlCapas;
    bool alarmaTomada=false;
    // Start is called before the first frame update
    void Start()
    {
       // contador = asAtmosfera.clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        alarmaTomada= goControlCapas.GetComponent<ControlCapas>().alarmaAtmos;
    }

    public void TargetEncontradoAtmos()
    {

        if (alarmaTomada == false)
       {
            asAtmosfera.Play();
            atrMentenAtmosfera.Play("AtmosferaAnimMenten", 0, 1);
      
        }
        /*
        else if (alarmaTomado > 1)
        {
         
            atrMentenAtmosfera.speed=0;
            asAtmosfera.Stop();
        }
        */
    }
}
