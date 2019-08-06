using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetenerAnimacion: MonoBehaviour
{
    public Animation _animation;
    // Start is called before the first frame update
    void Start()
    {
        _animation = this.gameObject.GetComponent<Animation>();
        if(_animation == null)
        {
            Debug.LogWarning("Animación es nulll");
        }
        _animation.Play("Bengala");
             _animation["Bengala"].speed = 0;

    }

}
