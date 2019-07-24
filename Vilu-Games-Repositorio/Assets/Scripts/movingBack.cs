using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBack : MonoBehaviour
{
    public bool touch;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        touch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (touch)
        {
            timer += Time.deltaTime;
            if (timer < 0.5f)
            {
                transform.Rotate(0, 0, 10f * Time.deltaTime);
            }
            else if(timer >= 1f)
            {

            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        touch = true;
    }

    private void OnTriggerStay(Collider other)
    {
        touch = true;
    }

    private void OnTriggerExit(Collider other)
    {
        touch = false;
    }
}
