using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PnjPierre : MonoBehaviour
{

    public Inventaire barreInventaire;
    public Objets hachePierre;
    public bool hacheRecuperer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void parlerPNJ()
    {
        if(hacheRecuperer == false)
        {
            Debug.Log("tiens la hache hihihihihi");
            if(barreInventaire.VerificationEtAjout(hachePierre.nomObjet, hachePierre.objetSprite, hachePierre.prefabObjet)== true)
            {
                hachePierre.objetPosseder = true;
                hacheRecuperer = true;
            }
        }
        

    }
}
