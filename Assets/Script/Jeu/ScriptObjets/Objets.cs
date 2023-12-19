using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objets : MonoBehaviour
{
    //fiche identite des objets
    public GameObject objetGameObject;
    public bool objetPosseder = false;
    public Sprite objetSprite;
    public string nomObjet = "";

    public GameObject prefabObjet;

    public Inventaire barreInventaire;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void testTosTest()
    {
        if (barreInventaire.VerificationEtAjout(nomObjet, objetSprite, prefabObjet) == true)
        {
            Debug.Log("un slot d'inventaire est dispo");
            Destroy(objetGameObject);
            objetPosseder = true;
        }
        else
        {
            Debug.Log("l'inventaire est plein");
        }
    }

    public void Fonctionne()
    {
        Debug.Log("it works");
    }
}
