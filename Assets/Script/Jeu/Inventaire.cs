using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{
    //bool pour verifier si on a un objet en main
    public bool objetEnMain = false;
    public GameObject objetTenus;
    public GameObject mainJoueur;
    public GameObject objectPrefabSlot0;             //le prefab qui sera affiché en main
    public GameObject objectPrefabSlot1;
    public GameObject objectPrefabSlot2;
    public GameObject objectPrefabSlot3;


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

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool VerificationEtAjout(string nomDeLobjet, Sprite spritDeLobjet, GameObject prefabDeLobjet)
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
                        objectPrefabSlot3 = prefabDeLobjet;
                        return true;        //l'emplacement 3 est libre
                    }
                }
                else
                {
                    //vu que c'est lire, on rajoute l'objet :
                    objetSlot2 = nomDeLobjet;
                    boutonSlot2.sprite = spritDeLobjet;
                    objectPrefabSlot2 = prefabDeLobjet;
                    return true;            //l'emplacement 2 est libre
                }
            }
            else
            {
                //vu que c'est lire, on rajoute l'objet :
                objetSlot1 = nomDeLobjet;
                boutonSlot1.sprite = spritDeLobjet;
                objectPrefabSlot1 = prefabDeLobjet;
                return true;                //l'emplacement 1 est libre
            }
        }
        else
        {
            //vu que c'est lire, on rajoute l'objet :
            objetSlot0 = nomDeLobjet;
            boutonSlot0.sprite = spritDeLobjet;
            objectPrefabSlot0 = prefabDeLobjet;
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
            objetTenus = Instantiate(objectPrefabSlot0, mainJoueur.transform);
            objetEnMain = true;
        }
        else if (objetSlot0 != "" && objetEnMain == true)
        {
            Debug.Log("on remet l'objet dans l'inventaire");
            Destroy(objetTenus);
            objetEnMain = false;
        }
    }
    public void BoutonSlot1()
    {
        if (objetSlot0 != "" && objetEnMain == false)
        {
            Debug.Log("on a l'objet en main");
            objetTenus = Instantiate(objectPrefabSlot1, mainJoueur.transform);
            objetEnMain = true;
        }
        else if (objetSlot0 != "" && objetEnMain == true)
        {
            Debug.Log("on remet l'objet dans l'inventaire");
            Destroy(objetTenus);
            objetEnMain = false;
        }
    }

    public void BoutonSlot2()
    {
        if (objetSlot0 != "" && objetEnMain == false)
        {
            Debug.Log("on a l'objet en main");
            objetTenus = Instantiate(objectPrefabSlot2, mainJoueur.transform);
            objetEnMain = true;
        }
        else if (objetSlot0 != "" && objetEnMain == true)
        {
            Debug.Log("on remet l'objet dans l'inventaire");
            Destroy(objetTenus);
            objetEnMain = false;
        }
    }

    public void BoutonSlot3()
    {
        if (objetSlot0 != "" && objetEnMain == false)
        {
            Debug.Log("on a l'objet en main");
            objetTenus = Instantiate(objectPrefabSlot3, mainJoueur.transform);
            objetEnMain = true;
        }
        else if (objetSlot0 != "" && objetEnMain == true)
        {
            Debug.Log("on remet l'objet dans l'inventaire");
            Destroy(objetTenus);
            objetEnMain = false;
        }
    }

    //Manip pour retirer un item de l'inventaire :
    //-supprimer le sprite et son string
    //-supprimer le prefab;
    public void SupprimerItemSlot0()
    {
        objetSlot0 = "";
        objectPrefabSlot0 = null;
        boutonSlot0.sprite = null;
    }
    public void SupprimerItemSlot1()
    {
        objetSlot1 = "";
        objectPrefabSlot1 = null;
        boutonSlot1.sprite = null;
    }
    public void SupprimerItemSlot2()
    {
        objetSlot2 = "";
        objectPrefabSlot2 = null;
        boutonSlot2.sprite = null;
    }
    public void SupprimerItemSlot3()
    {
        objetSlot3 = "";
        objectPrefabSlot3 = null;
        boutonSlot3.sprite = null;
    }
}
