using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public float vitesseDeplacementJoueur = 0.5f;
    public Rigidbody joueur;


    //private CharacterController controller;


    public LayerMask maskObjet;
    public LayerMask maskPierre;
    public LayerMask maskOuvrier;
    public LayerMask maskArbre;
    public LayerMask maskTasDePlanches;
    public Camera myCamera;

    public PnjPierre hacheBool;
    void Start()
    {
        //controller = GetComponent<CharacterController>();   
    }

    void Update()
    {

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector3.right * vitesseDeplacementJoueur;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector3.left * vitesseDeplacementJoueur;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = Vector3.forward * vitesseDeplacementJoueur;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = Vector3.back * vitesseDeplacementJoueur;

        }

        //deplacement
        // Vector3 Move = transform.right * joystickDeplacement.Horizontal + transform.forward * joystickDeplacement.Vertical;
        //controller.Move(Move*vitesseDeplacementJoueur*Time.deltaTime);


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

            if (Physics.Raycast(myCamera.transform.position, touchPosInWorld - myCamera.transform.position, out var infoTasPlanche, 1000000, maskTasDePlanches) && hacheBool.hacheDonner == true)
            {
                Debug.Log("test toucher planche");
                infoTasPlanche.transform.GetComponent<TasDePlanche>().DeposerPlanches();
            }
        }


    }


}

