using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LateStart(1));
       
    }

    // Update is called once per frame
    void Update()
    {
      //  transform.Rotate(90, 0, 0);
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        transform.Rotate(90, 0, 0);
    }
}
