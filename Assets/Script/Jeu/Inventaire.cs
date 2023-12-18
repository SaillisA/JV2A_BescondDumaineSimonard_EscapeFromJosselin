using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{
    //bool pour verifier si on a un objet en main
    public bool objetEnMain = false;
    public GameObject objetTenus;
    public GameObject mainJoueur;
    //lesSlots
    public Image boutonSlot0;
    public Image boutonSlot1;
    public Image boutonSlot2;
    public Image boutonSlot3;

    //vont prendre le nom de l'objets.
    public string objetSlot0 = "";
    public string objetSlot1 = "";
    public string objetSlot2 = "";
    public string objetSlot3 = "";

    //list pour verifier les emplacements de l'inventaire
    //public bool[] inventaireTab;

    //objets interactifs
    public Objets cleCoffre;
    //public Objets hache;
    public Objets scie;
    //public Objets planche;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cleCoffre.objetPosseder == true)
        {
            Debug.Log("j'ai la cle hehe");
            
        }

    }

    public bool VerificationEtAjout(string nomDeLobjet, Sprite spritDeLobjet)
    {
        /* Fonction qui verifie si il reste de la place dans l'inventaire
         * renvoie True si c'est le cas, et false si l'inventaire n'a plus d'emplacement libre
         */
        Debug.Log("verification de la liste");
        if(objetSlot0 != "")
        {
            if(objetSlot1 != "")
            {
                if (objetSlot2 != "")
                {
                    if(objetSlot3 != "")
                    {
                        return false;       //aucune emplacement n'est libre
                    }
                    else
                    {
                        //vu que c'est lire, on rajoute l'objet :
                        objetSlot3 = nomDeLobjet;
                        boutonSlot3.sprite = spritDeLobjet;
                        return true;        //l'emplacement 3 est libre
                    }
                }
                else
                {
                    //vu que c'est lire, on rajoute l'objet :
                    objetSlot2 = nomDeLobjet;
                    boutonSlot2.sprite = spritDeLobjet;
                    return true;            //l'emplacement 2 est libre
                }
            }
            else
            {
                //vu que c'est lire, on rajoute l'objet :
                objetSlot1 = nomDeLobjet;
                boutonSlot1.sprite = spritDeLobjet;
                return true;                //l'emplacement 1 est libre
            }
        }
        else
        {
            //vu que c'est lire, on rajoute l'objet :
            objetSlot0 = nomDeLobjet;
            boutonSlot0.sprite = spritDeLobjet;
            return true;                    //l'emplacement 0 libre
        }  
        
        
        //ceci fait crash Unity snif snif
        /*for (int i = 0; i < inventaireTab.Length;)
        {
            if (inventaireTab[i] == false)
            {
                //on met inventaireTab[i] = true;
                //on met objetSlot[i] = nomObjet;
                return true;
            }
        }
        return false;*/
    }

    public void BoutonSlot0()
    {
        Debug.Log("coucou");
        if(objetSlot0 != "" && objetEnMain == false)
        {
            Debug.Log("on a l'objet en main");
            objetTenus = Instantiate(cleCoffre, mainJoueur.transform).gameObject;
            objetEnMain = true;
        }
        else if (objetSlot0 != "" && objetEnMain == true)
        {
            Debug.Log("on remet l'objet dans l'inventaire");
            Destroy(objetTenus);
            objetEnMain = false;
        }
    }
}
