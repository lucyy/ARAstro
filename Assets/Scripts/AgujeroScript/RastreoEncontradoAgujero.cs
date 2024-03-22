using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RastreoEncontradoAgujero : MonoBehaviour
{

    public AudioSource asAgujero;
    public Animator atrMentenAgujero;
    public GameObject goControlAgujero;
    bool alarmaTomada=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alarmaTomada = goControlAgujero.GetComponent<AgujeroControlMenten>().alarmaAgujero;
    }

    public void TargetEncontradoAgujero()
    {

        if (alarmaTomada == false)
        {
            asAgujero.Play();

            // atrMentenSaludo.speed = 1;
            atrMentenAgujero.Play("AgujeroAnimMenten", 0, 1);
        }
    }
}
