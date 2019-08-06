using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject Player;
    public AudioSource aud;
    public bool trigger;

    // Start is called before the first frame update
    void Start()
    {
        trigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            KillAudio();
        }
    }

    public void KillAudio()
    {
        if (!aud.isPlaying)
        {
            Destroy(gameObject);
        }
    }

    public void RadioAudio()
    {
        aud.transform.position = Player.transform.position;
        aud.PlayOneShot(aud.clip);
        trigger = true;
    }

    public void Routine()
    {
        StartCoroutine("dialogue");
    }

    IEnumerator dialogue()
    {
        RadioAudio();
        yield return null;
    }
}
