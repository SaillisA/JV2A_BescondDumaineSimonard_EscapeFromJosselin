using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Joueur : MonoBehaviour
{
    public float vitesseDeplacementJoueur = 0.5f;
    public Rigidbody joueur;
    //public ButtonExtantion boutonPresser;

    public LayerMask maskObjet;
    public LayerMask maskPierre;
    public LayerMask maskOuvrier;
    public LayerMask maskArbre;
    public LayerMask maskTasDePlanches;
    public LayerMask maskScie;
    public Camera myCamera;

    public PnjPierre hacheBool;
    public TasDePlanche tasPlanche;
    void Start()
    {
        joueur = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Recuperer un objet
        if (Input.touchCount > 0)
        {
            Vector3 touchPos = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, myCamera.farClipPlane);
            Vector3 touchPosInWorld = myCamera.ScreenToWorldPoint(touchPos);
            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoObjet, 100, maskObjet))
            {
                infoObjet.transform.GetComponent<Objets>().testTosTest();
            }

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoPierre, 1000000, maskPierre))
            {
                infoPierre.transform.GetComponent<PnjPierre>().parlerPNJ();
            }

            /*
            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoOuvrier, 1000000, maskOuvrier))
            {
                infoOuvrier.transform.GetComponent<PnjOuvrier>().ParlerOuvrier();
            }*/

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoArbre, 1000000, maskArbre) && hacheBool.hacheDonner == true )
            {
                Debug.Log("test toucher arbre");
                infoArbre.transform.GetComponent<Arbre>().couperBois();
            }

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoTasPlanche, 1000000, maskTasDePlanches))
            {
                Debug.Log("test toucher planche");
                infoTasPlanche.transform.GetComponent<TasDePlanche>().DeposerPlanches();
            }

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoScie, 1000000, maskScie) && tasPlanche.planchesTachesFinis == true)
            {
                Debug.Log("test toucher scie");
                infoScie.transform.GetComponent<ScieScript>().TrouverScie();
            }
        }


    }

    public void DeplacementDroite()
    {
        Debug.Log("coucou");
        joueur.velocity = transform.right * vitesseDeplacementJoueur;
    }
    public void DeplacementGauche()
    {
        Debug.Log("coucou");
        joueur.velocity = transform.right * (-vitesseDeplacementJoueur);
    }
    public void DeplacementDevant()
    {
        Debug.Log("coucou");
        joueur.velocity = transform.forward * vitesseDeplacementJoueur;
    }
    public void DeplacementDerriere()
    {
        Debug.Log("coucou");
        joueur.velocity = transform.forward * (-vitesseDeplacementJoueur);
    }
    public void OuvrirMenuPause()
    {
        SceneManager.LoadScene("ScenePause");
    }


}

