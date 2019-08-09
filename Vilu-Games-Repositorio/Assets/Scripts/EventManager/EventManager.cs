using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventManager : MonoBehaviour
{
    #region Variables
    //Referencias
    public Player player;

    //Variables
    public string progress, playerSees;
    public int objectives, total;
    private bool radioCompleted, sangreCompleted, campCompleted, corpseCompleted, finalCompleted;

    //Triggers
    bool hasRadio; // Tiene mapa
    bool spooked; // Jugador ve algo perturbador

    //Eventos
    public UnityEvent RadioAuto;
    public UnityEvent RastroSangre;
    public UnityEvent Campamento;
    //public UnityEvent Lluvia;
    public UnityEvent Cadaver;
    public UnityEvent Miedo;
    public RadioController radioController;
    #endregion

    void Start()
    {
        radioCompleted = false;
        sangreCompleted = false;
        campCompleted = false;
        corpseCompleted = false;
        finalCompleted = false;
        objectives = 0;
        total = 6;
        progress = "Objectives completed: " + objectives + "/" + total;
        Debug.Log(progress);
    }

    void Update()
    {
        //What the player sees
        playerSees = player.see;

        if (!radioCompleted)
        {
            EventoRadioAuto();
        }

        if (!sangreCompleted)
        {
            EventoSangre();
        }

        if (!campCompleted)
        {
            EventoCamp();
        }

        if (!corpseCompleted)
        {
            EventoCadaver();
        }

        if (!finalCompleted)
        {
            EventoFinal();
        }
    }

    #region Primer ACTO
    public void EventoRadioAuto()
    {
        // RADIO
        hasRadio = player.hasRadio;
        if (hasRadio == true)
        {
            // Reproducir Sonido
            RadioAuto.Invoke();
            Debug.Log("Radio Picked up!");
            objectives += 1;
            progress = "Objectives completed: " + objectives + "/" + total;
            Debug.Log(progress);
            radioCompleted = true;
            radioController.RadioDialogo(0);
        }
    }
    #endregion

    #region Segundo ACTO
    // Mancha de sangre
    public void EventoSangre()
    {
        if (playerSees == "Evt_SANGRE")
        {
            RastroSangre.Invoke();
            Debug.Log("Clue founded: BLOOD!");
            objectives += 1;
            progress = "Objectives completed: " + objectives + "/" + total;
            Debug.Log(progress);
            sangreCompleted = true;
            radioController.RadioDialogo(1);

        }
    }
    // Campamento
    public void EventoCamp()
    {
        if (playerSees == "Carpa")
        {
            Campamento.Invoke();
            Debug.Log("Clue Founded: CAMP!");
            objectives += 1;
            progress = "Objectives completed: " + objectives + "/" + total;
            Debug.Log(progress);
            campCompleted = true;
            radioController.RadioDialogo(2);
        }
    }
    // Lloviendo
    #endregion

    #region ACTO FINAL
    // Cadaver
    public void EventoCadaver()
    {
        if (playerSees == "CADAVER")
        {
            Campamento.Invoke();
            Debug.Log("BRUH: CADAVER!");
            objectives += 1;
            progress = "Objectives completed: " + objectives + "/" + total;
            Debug.Log(progress);
            corpseCompleted = true;
            radioController.RadioDialogo(3);
        }
    }
    // Desaparicion Enemigo
    public void EventoFinal()
    {
        if (playerSees == "Enemy")
        {
            Campamento.Invoke();
            Debug.Log("YOU BETTER RUN BRUH!");
            objectives += 1;
            progress = "Objectives completed: " + objectives + "/" + total;
            Debug.Log(progress);
            finalCompleted = true;
        }
    }
    #endregion
}
