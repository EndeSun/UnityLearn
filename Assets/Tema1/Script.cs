using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public Text textUI;
    public float velocidad = 15f;
    public GameObject cubo1;
    public GameObject cubo2;
    public GameObject cubo3;

  
    void Start()
    {
        textUI.text = "Transformaciones";
    }

    void Update()
    {
        cubo1.transform.Rotate(0, velocidad*Time.deltaTime, 0);
        cubo2.transform.Rotate(0, velocidad*Time.deltaTime, 0);
    }

    private void FixedUpdate()
    {
        cubo3.transform.Rotate(0, velocidad*Time.deltaTime, 0);
    } 
}
