using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public float velocidad = 5f;

     
    // Update is called once per frame
    void Update()
    {
        float movimiento = velocidad * Time.deltaTime;

        transform.position += new Vector3(movimiento, 0, 0);

        if(transform.position.x > 5 || transform.position.x < -5)
        {
            velocidad = -velocidad;
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        if (transform.position.y > 5)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }else if (transform.position.y < -5)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
