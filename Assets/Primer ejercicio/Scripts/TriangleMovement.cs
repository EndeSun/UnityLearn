using UnityEngine;

public class TriangleMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float lado = 10f;

 
    private const int DERECHA = 0;
    private const int ARRIBA_IZQUIERDA =1;
    private const int ABAJO_IZQUIERDA = 2;

    private Vector3 inicio;
    private int direccion = DERECHA;

    private Vector3 puntoObjetivo;
    private Vector3 puntoA, puntoB, puntoC;



    void Start()
    {
        inicio = Vector3.zero;

        puntoA = inicio;
        puntoB = inicio + new Vector3(lado, 0, 0);
        puntoC = puntoB + new Vector3(-lado / 2, 0, Mathf.Sqrt(3) * lado / 2);

        puntoObjetivo = puntoB;
    }

    // Update is called once per frame
    void Update()
    {
        // Vector del movimiento --> Se mueve hasta el punto objetivo
        Vector3 movimiento = (puntoObjetivo - transform.position).normalized * velocidad * Time.deltaTime;

        if (Vector3.Distance(transform.position, puntoObjetivo) > velocidad * Time.deltaTime)
        {
            transform.position += movimiento;
        }
        //Aquí ha llegado al punto Objetivo
        else
        {
            transform.position = puntoObjetivo;

            switch (direccion)
            {
                case DERECHA:
                    puntoObjetivo = puntoC;
                    direccion = ARRIBA_IZQUIERDA;
                    break;
                case ARRIBA_IZQUIERDA:
                    puntoObjetivo = puntoA;
                    direccion = ABAJO_IZQUIERDA;
                    break;
                case ABAJO_IZQUIERDA:
                    puntoObjetivo = puntoB;
                    direccion = DERECHA;
                    break;
            }
        }
    }
}
