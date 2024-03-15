using UnityEngine;

public class Espiral : MonoBehaviour
{
    public float radio = 10f;
    public int vueltas = 3;
    public int puntosPorVuelta = 100;
    public float indiceSubida = 0.1f;
    int i = 0;




    // Start is called before the first frame update
    void Start()
    {
        do
        {
            float angulo = Mathf.PI * 2 * i / puntosPorVuelta;

            float x = radio * Mathf.Cos(angulo);
            float z = radio * Mathf.Sin(angulo);
            float y = i * indiceSubida;

            GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            newCube.transform.position = new Vector3(x, y, z);

            radio = (radio<=1) ? 1 : radio - 0.05f;
            i++;
        }

        while (i < vueltas * puntosPorVuelta);
    }  

    // Update is called once per frame
    void Update()
    {
        
    }
}
