using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioController : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] dialogosRadio;
    private AudioSource audRadio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioClip GetDialogo(int dialogo)
    {
        return dialogosRadio[dialogo];
    }

    public void RadioDialogo(int sonido)
    {
        AudioClip clip = GetDialogo(sonido);
        audRadio.PlayOneShot(clip);
    }

}
