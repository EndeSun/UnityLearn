using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    public Transform objetivo; // Así accedemos directamente: objetivo.position
    //public GameObject objetivo; --> De esta manera tenemos que acceder a su posición de la siguiente manera: objetivo.transform.position
    public float velocidad = 5f;
    public float distanciaSeguimiento = 5f;
    public float distanciaEvasion = 2f;

    // Update is called once per frame
    void Update()
    {
        float distanciaObjetivo = Vector3.Distance(transform.position, objetivo.position);

        if(distanciaObjetivo < distanciaEvasion)
        {
            //evasión
            Vector3 direccion = (transform.position - objetivo.transform.position).normalized;
            transform.position += direccion * velocidad * Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (distanciaObjetivo < distanciaSeguimiento)
        {
            //seguimiento
            Vector3 direccion = (objetivo.transform.position - transform.position).normalized;
            // I want to move from transform.position to objective position, so We have to invert the two points
            transform.position += direccion * velocidad * Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.red;
        }

    }
}
 