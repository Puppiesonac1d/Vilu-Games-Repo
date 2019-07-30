using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventManager : MonoBehaviour
{
    #region Variables
    //Referencias
    public Player player;

    //Triggers
    bool hasRadio;

    //Eventos
    public UnityEvent radioAuto;
    #endregion

    void Update()
    {
        EventoRadioAuto();
    }

    void EventoRadioAuto()
    {
        hasRadio = player.hasRadio;
        if (hasRadio == true)
        {
            radioAuto.Invoke();
            Debug.Log("Evento 1 disparado");
        }
    }
}
