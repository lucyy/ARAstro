using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionPlaneta: MonoBehaviour
{

    float velocidad = 5;
    public Transform trmTelescopio;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(200* Time.deltaTime, 0, 0);

        /*
        if (transform.rotation.eulerAngles.z > -60)
     
        {
            velocidad = 0;
       }
        */
        
      transform.RotateAround(trmTelescopio.position, -Vector3.forward, velocidad * Time.deltaTime);
    }
}
