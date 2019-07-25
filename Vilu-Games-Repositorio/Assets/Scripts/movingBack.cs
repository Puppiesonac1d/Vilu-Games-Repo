using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBack : MonoBehaviour
{
    public bool touch;
    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        touch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (touch)
        {
            ani.SetBool("passing", true);
            ani.Play("movingBrush");
        }
        else
        {
            ani.SetBool("passing", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Body")
        {
            touch = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Body")
        {
            if (other.GetComponentInParent<Rigidbody>().velocity.magnitude > 0)
            {
                touch = true;
            }
            else
            {
                touch = false;
                Debug.Log("STAHP!!!!!");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Body")
        {
            touch = false;
        }
    }
}
