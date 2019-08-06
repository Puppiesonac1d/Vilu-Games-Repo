using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetenerAnimacion: MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audioData;
    [SerializeField]private Animator animatorController;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioData.PlayOneShot(clip);
            animatorController.SetBool("disparar", true);
            animatorController.SetBool("brillando", true);
           
        }

    }

}
