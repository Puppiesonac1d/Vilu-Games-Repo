using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PlayerMag : MonoBehaviour
{
    public bool hasRadio, spooked;
    public string see;
    private Ray landingRay;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerTarget();
    }

    public void PlayerTarget()
    {
        landingRay = new Ray(transform.position, transform.forward);

        // What the player sees
        if (Physics.Raycast(landingRay, out hit, 100f))
        {
            see = hit.collider.gameObject.name;
        }
    }
}
