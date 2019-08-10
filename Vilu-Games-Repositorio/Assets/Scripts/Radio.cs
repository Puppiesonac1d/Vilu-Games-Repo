using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Radio : MonoBehaviour
{
    public SteamVR_Action_Boolean grabGripAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("GrabGrip");
    public PlayerMag pm;
    public bool touching;

    // Start is called before the first frame update
    void Start()
    {
        touching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (touching)
        {
            PickedUP();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        touching = true;
    }

    private void OnTriggerStay(Collider other)
    {
        touching = true;
    }

    private void OnTriggerExit(Collider other)
    {
        touching = false;
    }

    public void PickedUP()
    {
        if (grabGripAction.GetStateDown(SteamVR_Input_Sources.Any))
        {
            pm.hasRadio = true;
            Destroy(gameObject);
        }
    }
}
