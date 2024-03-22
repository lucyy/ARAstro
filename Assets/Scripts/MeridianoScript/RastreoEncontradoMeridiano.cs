using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RastreoEncontradoMeridiano : MonoBehaviour
{
    public AudioSource asMeridiano;
    public Animator atrMentenMeridiano;
    public GameObject goControlMeridiano;
    bool alarmaTomada=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alarmaTomada = goControlMeridiano.GetComponent<ControlMentenAstronomo>().alarmaMeridiano;
    }

    public void TargetEncontradoMeridiano()
    {

        if (alarmaTomada == false)
        {
            asMeridiano.Play();

            // atrMentenSaludo.speed = 1;
            atrMentenMeridiano.Play("TManimMenten", 0, 1);
        }
    }
}
