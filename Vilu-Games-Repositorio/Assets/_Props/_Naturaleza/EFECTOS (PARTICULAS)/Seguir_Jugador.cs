using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir_Jugador : MonoBehaviour
{
    public GameObject jugador;
    public GameObject efecto;
    public float x;
    public float z;
    public float y;
    
    
    void Start()
    {  
        x = jugador.transform.position.x;
        z = jugador.transform.position.z;
        Vector3 newPos = new Vector3(x, 0, z);
    }

   
    void Update()
    {
        x = jugador.transform.position.x;
        z = jugador.transform.position.z;
        Vector3 newPos = new Vector3(x, y, z);
        efecto.transform.position = newPos;
    }
}
