using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RastreoEncontradoSismo : MonoBehaviour
{

    public AudioSource asSismo;
    public Animator atrMentenSismo;
    public GameObject goControlSismo;
    bool alarmaTomada=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alarmaTomada = goControlSismo.GetComponent<SismoControl>().alarmaSismo;
    }

    public void TargetEncontradoSismo()
    {

        if (alarmaTomada == false)
        {
            asSismo.Play();

            // atrMentenSaludo.speed = 1;
            atrMentenSismo.Play("SismoAnimMenten", 0, 1);
        }
    }
}
