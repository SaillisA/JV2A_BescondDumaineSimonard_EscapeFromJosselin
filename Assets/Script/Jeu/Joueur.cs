using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Joueur : MonoBehaviour
{
    public float vitesseDeplacementJoueur = 0.5f;
    public Rigidbody joueur;
    public LayerMask maskObjet;
    public LayerMask maskPierre;
    public LayerMask maskOuvrier;
    public LayerMask maskArbre;
    public LayerMask maskTasDePlanches;
    public LayerMask maskScie;
    public LayerMask maskPorte;
    public LayerMask maskEmplacementPalissade;

    public Camera myCamera;

    public PnjPierre pierre;
    public TasDePlanche tasPlanche;

    public ButtonExtantion boutonDeplacement1;
    public ButtonExtantion boutonDeplacement2;
    public ButtonExtantion boutonDeplacement3;
    public ButtonExtantion boutonDaplacement4;

    public GameObject canvasJeu;
    public GameObject canvasMenuPause;
    public GameObject canvaParametre;

    void Start()
    {
        joueur = GetComponent<Rigidbody>();
        canvasMenuPause.gameObject.SetActive(false);
        canvaParametre.gameObject.SetActive(false);
    }

    void Update()
    {
        if(boutonDeplacement1.activeBouton == false && boutonDeplacement2.activeBouton == false && boutonDeplacement3.activeBouton == false && boutonDaplacement4.activeBouton == false)
        {
            joueur.velocity = new Vector3 (0, joueur.velocity.y, 0);
            //joueur.velocity = transform.right * 0.0f;
        }

        //Recuperer un objet
        if (Input.touchCount > 0)
        {
            Vector3 touchPos = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, myCamera.farClipPlane);
            Vector3 touchPosInWorld = myCamera.ScreenToWorldPoint(touchPos);
            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoObjet, 10, maskObjet))
            {
                infoObjet.transform.GetComponent<Objets>().testTosTest();
            }

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoPierre, 10, maskPierre))
            {
                infoPierre.transform.GetComponent<PnjPierre>().parlerPNJ();
            }

            /*
            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoOuvrier, 1000000, maskOuvrier))
            {
                infoOuvrier.transform.GetComponent<PnjOuvrier>().ParlerOuvrier();
            }*/

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoArbre, 10, maskArbre) && pierre.hacheDonner == true )
            {
                Debug.Log("test toucher arbre");
                infoArbre.transform.GetComponent<Arbre>().couperBois();
            }

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoTasPlanche, 10, maskTasDePlanches))
            {
                Debug.Log("test toucher planche");
                infoTasPlanche.transform.GetComponent<TasDePlanche>().DeposerPlanches();
            }

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoScie, 10, maskScie) && tasPlanche.planchesTachesFinis == true)
            {
                Debug.Log("test toucher scie");
                infoScie.transform.GetComponent<ScieScript>().TrouverScie();
            }

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoPorte, 10, maskPorte))
            {
                Debug.Log("test toucher porte");
                infoPorte.transform.GetComponent<ScriptPorte>().FinJeuPorte();
            }

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoPalissade, 10, maskEmplacementPalissade))
            {
                Debug.Log("test construction Palissade");
                infoPalissade.transform.GetComponent<ScriptFuturPalissade>().ConstruirePalissade();
            }
        }


    }

    public void DeplacementDroite()
    {
        if(boutonDeplacement1 == true)
        {
            //joueur.velocity = new Vector3(transform.right.x, joueur.velocity.y, joueur.velocity.z) * vitesseDeplacementJoueur;
            joueur.velocity = transform.right * vitesseDeplacementJoueur;
        }
        
    }
    public void DeplacementGauche()
    {
        if(boutonDeplacement2 == true)
        {
            //joueur.velocity = new Vector3(transform.right.x, joueur.velocity.y, joueur.velocity.z) * -vitesseDeplacementJoueur;
            joueur.velocity = transform.right * (-vitesseDeplacementJoueur);
        }
        
    }
    public void DeplacementDevant()
    {
        if (boutonDeplacement3)
        {
            //joueur.velocity = new Vector3(joueur.velocity.x, joueur.velocity.y, transform.forward.z) * vitesseDeplacementJoueur;
            joueur.velocity = transform.forward * vitesseDeplacementJoueur;
        }
            
    }
    public void DeplacementDerriere()
    {
        if (boutonDaplacement4)
        {
            //joueur.velocity = new Vector3(joueur.velocity.x, joueur.velocity.y, transform.forward.z) * -vitesseDeplacementJoueur;
            joueur.velocity = transform.forward * (-vitesseDeplacementJoueur);
        }
        
    }
    public void OuvrirMenuPause()
    {
        SceneManager.LoadScene("ScenePause");
    }

    public void BoutonPause()
    {
        canvasJeu.gameObject.SetActive(false);
        canvasMenuPause.gameObject.SetActive(true);
    }
}

