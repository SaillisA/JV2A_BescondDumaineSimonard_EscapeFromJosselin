using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasDePlanche : MonoBehaviour
{

    public Inventaire barreInventaire;
    public int planchesNecessaires = 3;             //le joueur doit emmener 3 planches;

    public PnjOuvrier ouvrier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeposerPlanches()
    {
        if(barreInventaire.objetSlot0 == "Planche")
        {
            Debug.Log("la planche ça degage");
            barreInventaire.SupprimerItemSlot0();
            planchesNecessaires -= 1;
        }
        if (barreInventaire.objetSlot1 == "Planche")
        {
            Debug.Log("la planche ça degage");
            barreInventaire.SupprimerItemSlot1();
            planchesNecessaires -= 1;
        }
        if (barreInventaire.objetSlot2 == "Planche")
        {
            Debug.Log("la planche ça degage");
            barreInventaire.SupprimerItemSlot2();
            planchesNecessaires -= 1;
        }
        if (barreInventaire.objetSlot3 == "Planche")
        {
            Debug.Log("la planche ça degage");
            barreInventaire.SupprimerItemSlot3();
            planchesNecessaires -= 1;
        }
        Debug.Log("je pose des planches");
        if(planchesNecessaires <= 0)
        {
            Debug.Log("Tous le bois est déposé");
            ouvrier.ParlerOuvrier();
        }
    }
}
