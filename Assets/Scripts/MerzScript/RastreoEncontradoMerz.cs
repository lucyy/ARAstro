using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RastreoEncontradoMerz : MonoBehaviour
{

    public AudioSource asMerz;
    public Animator atrMentenMerz;
    public GameObject goControlMerz;
    bool alarmaTomada=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alarmaTomada = goControlMerz.GetComponent<MerzControl>().alarmaMerz;
    }

    public void TargetEncontradoMerz()
    {

        if (alarmaTomada == false)
        {
            asMerz.Play();

            // atrMentenSaludo.speed = 1;
            atrMentenMerz.Play("MerzAnimMenten", 0, 1);
        }
    }
}
