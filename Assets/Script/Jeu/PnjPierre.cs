using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class PnjPierre : MonoBehaviour
{

    public Inventaire barreInventaire;
    public Objets hachePierre;
    public bool hacheDonner = false;

    //texte :
    public GameObject boutonTexte;
    public TextMeshProUGUI textePnj;
    public TextMeshProUGUI nomTextePnj;

    public int compteurAppuieSurPnj;

    public bool etape0 = false;             //suivre Pierre
    public bool etape1 = false;             //Couper Bois
    public bool etape2 = false;             //Amener Bois au chantier
    public bool etape3 = false;             //Chercher Scie
    public bool etape4 = false;             //Chercher les outils
    public bool etape5 = false;             //Monter la palissade      

    // Start is called before the first frame update
    void Start()
    {
        boutonTexte.gameObject.SetActive(true);
        nomTextePnj.text = "Pierre";
        textePnj.text = "Tire-au-Oh Tire-au-flanc, tu comptes prendre racine ? Allez, allez on se magne ! Suis-moi!";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void parlerPNJ()
    {
        if(etape1 == false)
        {
            if(compteurAppuieSurPnj == 0)
            {
                boutonTexte.gameObject.SetActive(true);
                nomTextePnj.text = "Pierre";
                textePnj.text = "Où est ta hache ?";
            }
            if(compteurAppuieSurPnj == 2)
            {
                boutonTexte.gameObject.SetActive(true);
                nomTextePnj.text = "Pierre";
                textePnj.text = "T’es pas futé gamin. Amènes en 3 au chantier\r\n";
            }
        }
        if(etape2 == false)
        {
            if(compteurAppuieSurPnj == 0)
            {

            }
        }

    }
    public void DonnerHache()
    {
        if (hacheDonner == false)
        {
            Debug.Log("tiens la hache hihihihihi");
            if (barreInventaire.VerificationEtAjout(hachePierre.nomObjet, hachePierre.objetSprite, hachePierre.prefabObjet) == true)
            {
                hachePierre.objetPosseder = true;
                hacheDonner = true;
            }
        }
    }
    public void BoutonTextePierre()
    {
        if(etape0 == false)
        {
            boutonTexte.gameObject.SetActive(false);
            etape0 = true;
        }
        else if(etape1 == false && compteurAppuieSurPnj == 0)
        {
            nomTextePnj.text = "Pierre";
            textePnj.text = "Tiens et hâte toi, on doit finir cette palissade avant la tombée de la nuit";
            compteurAppuieSurPnj = 1;
        }
        else if(etape1 == false && compteurAppuieSurPnj ==1)
        {
            DonnerHache();
            compteurAppuieSurPnj = 2;
            boutonTexte.gameObject.SetActive(false);
        }
        else if(etape1 ==false && compteurAppuieSurPnj == 2)
        {
            etape1= true;
            compteurAppuieSurPnj = 0;
            boutonTexte.gameObject.SetActive(false);
        }

    }
}
