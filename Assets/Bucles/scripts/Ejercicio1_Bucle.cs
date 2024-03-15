using UnityEngine;

public class Ejercicio1_Bucle : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //The same code but with while  
        //int x = 0;
        //while(x < 10)
        //{
        //    Vector3 positionNew = new Vector3(x * 1.2f, 0, 0);
        //
        //    GameObject cubeNew = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //    cubeNew.transform.position = positionNew;
        //    cubeNew.GetComponent<Renderer>().material.color = (x % 2 == 0) ? Color.red : Color.blue;
        //    x++;
        //}


        for (int i = 0; i < 10; i++)
        {
            Vector3 positionNew = new Vector3(i * 1.2f, 0, 0);
            GameObject cubeNew = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubeNew.transform.position = positionNew;

            cubeNew.GetComponent<Renderer>().material.color = (i % 2 == 0) ? Color.red : Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
