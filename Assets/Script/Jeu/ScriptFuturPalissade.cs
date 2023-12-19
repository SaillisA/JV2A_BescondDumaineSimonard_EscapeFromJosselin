using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFuturPalissade : MonoBehaviour
{
    // Start is called before the first frame update
    public PnjPierre pierre;
    public Inventaire inventaire;
    public int objetPosseder = 0;

    public string nomCorde = "Corde";
    public string nomMarteau = "Marteau";
    public string nomPlanche = "Planche";
    public void ConstruirePalissade()
    {
        if (verifItem())
        {
            Debug.Log("la palissade est faite");
            inventaire.SupprimerItemSlot0();
            inventaire.SupprimerItemSlot1();
            inventaire.SupprimerItemSlot2();
            inventaire.SupprimerItemSlot3();
            pierre.DialoguePierreFinNiveau();
        }
        else
        {
            Debug.Log("Il manque un truc");
        }
    }


    public bool verifItem()
    {
        if(inventaire.objetSlot0 == nomCorde || inventaire.objetSlot0 ==nomMarteau || inventaire.objetSlot0 == nomPlanche)
        {
            objetPosseder++;
        }
        if (inventaire.objetSlot1 == nomCorde || inventaire.objetSlot1 == nomMarteau || inventaire.objetSlot1 == nomPlanche)
        {
            objetPosseder++;
        }
        if (inventaire.objetSlot2 == nomCorde || inventaire.objetSlot2 == nomMarteau || inventaire.objetSlot2 == nomPlanche)
        {
            objetPosseder++;
        }
        if (inventaire.objetSlot3 == nomCorde || inventaire.objetSlot3 == nomMarteau || inventaire.objetSlot3 == nomPlanche)
        {
            objetPosseder++;
        }

        if(objetPosseder == 3)
        {
            return true;
        }
        objetPosseder = 0;
        return false;
    }
}
