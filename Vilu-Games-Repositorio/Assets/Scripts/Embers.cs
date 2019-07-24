using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embers : MonoBehaviour
{
    public float time;
    public float intensity;
    public bool tic;

    // Start is called before the first frame update
    void Start()
    {
        intensity = 2;
        tic = true;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().intensity = intensity;
        Flow();
    }

    public void Flow() // FUCK
    {
        if (intensity >= 3)
        {
            tic = true;
        }
        else if (intensity <= 2)
        {
            tic = false;
        }

        if (tic)
        {
            intensity -= 0.5f * Time.deltaTime;
        }
        else
        {
            intensity += 0.5f * Time.deltaTime;
        }
    }
}
