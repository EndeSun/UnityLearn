using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadradoMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float lado = 10f;

    public const int ARRIBA = 0;
    public const int ABAJO = 1;
    public const int IZQUIERDA = 2;
    public const int DERECHA = 3;

    private Vector3 inicio, pos;
    private int direccion = DERECHA;

    // Start is called before the first frame update
    void Start()
    {
        inicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = direccion switch
        {
            DERECHA => Vector3.right,
            ARRIBA => Vector3.forward,
            IZQUIERDA => Vector3.left,
            ABAJO => Vector3.back,
            _ => Vector3.zero,
        };

        transform.position += mov * velocidad * Time.deltaTime;
        pos = transform.position;

        if (direccion == DERECHA && pos.x >= inicio.x + lado)       direccion = ARRIBA;
        else if (direccion == ARRIBA && pos.z >= inicio.z + lado)   direccion = IZQUIERDA;
        else if (direccion == IZQUIERDA && pos.x <= inicio.x)       direccion = ABAJO;
        else if (direccion == ABAJO && pos.z <= inicio.z)           direccion = DERECHA;

    }
}
