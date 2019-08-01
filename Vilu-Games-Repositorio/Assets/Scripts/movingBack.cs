using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBack : MonoBehaviour
{
    public bool touch;
    public Animator ani;
    //variables de audio
    [SerializeField]
    private AudioClip[] sonidosArbusto; // lista con los sonidos del arbusto
    // [0] es el sonido de toque al arbusto, [1] es el sonido de atravesar el arbusto
    private AudioSource audioArbusto;

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
            SuenaArbusto(0);// 0 es el sonido de toque
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Body")
        {
            if (other.GetComponentInParent<Rigidbody>().velocity.magnitude > 0)
            {
                touch = true;
                SuenaArbusto(1); // 1 es el sonido de atravesar
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

    private AudioClip GetSonido(int sonido)
    {// sonido = 0 = toque de arbusto
        //sonido = 1 = atravezar arbusto
        return sonidosArbusto[sonido];
    }

    private void SuenaArbusto(int sonido)
    {
        AudioClip clip = GetSonido(sonido);
        audioArbusto.PlayOneShot(clip);
    }
}
