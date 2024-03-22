using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RastreoEncontradoSaludo : MonoBehaviour
{

    public AudioSource asSaludo;
    public Animator atrMentenSaludo;
    public GameObject goControlSaludo;
    bool alarmaTomada=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alarmaTomada = goControlSaludo.GetComponent<IntroEventos>().alarmaIntro;
    }

    public void TargetEncontradoSaludo()
    {
        if (alarmaTomada == false)
        {
            asSaludo.Play();
            atrMentenSaludo.Play("IntroAnimMenten", 0, 1);
        }
    }
}
