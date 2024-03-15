using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour
{
    public Vector3[] posicionesObjeto =
    {
        new Vector3(0,0,0),
        new Vector3(1,1,0),
        new Vector3(2,0,2)
    };

    public float tiempoEntrePosiciones = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Mover());
    }

    IEnumerator Mover()
    {
        //Infinite loop
        while (true)
        {
            foreach (Vector3 posicionObjeto in posicionesObjeto)
            {
                transform.position = posicionObjeto;
                yield return new WaitForSeconds(tiempoEntrePosiciones);
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
