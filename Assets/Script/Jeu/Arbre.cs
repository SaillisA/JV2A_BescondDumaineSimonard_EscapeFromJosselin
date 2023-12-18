using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbre : MonoBehaviour
{
    // Start is called before the first frame update
    public bool arbreMort = false;
    public Inventaire barreInventaire;
    public Objets planche;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void couperBois()
    {
        if (arbreMort == false)
        {
            Debug.Log("tiens la hache hihihihihi");
            if (barreInventaire.VerificationEtAjout(planche.nomObjet, planche.objetSprite, planche.prefabObjet) == true)
            {
                planche.objetPosseder = true;
                arbreMort = true;
            }
        }
    }
}
