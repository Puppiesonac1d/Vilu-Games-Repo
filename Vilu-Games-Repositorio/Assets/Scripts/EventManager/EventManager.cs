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
    bool hasRadio; // Tiene mapa
    bool spooked; // Jugador ve algo perturbador

    //Eventos
    public UnityEvent radioAuto;
    #endregion

    void Update()
    {
        EventoRadioAuto();
    }

    #region Primer ACTO
    // RADIO
    void EventoRadioAuto()
    {
        hasRadio = player.hasRadio;
        if (hasRadio == true)
        {
            radioAuto.Invoke();
            Debug.Log("Evento 1 disparado");
        }
    }
    #endregion

    #region Segundo ACTO
    // Mancha de sangre

    // Campamento

    // Lloviendo
    #endregion

    #region ACTO FINAL
    // Cadaver

    // Desaparicion Enemigo
    #endregion
}
