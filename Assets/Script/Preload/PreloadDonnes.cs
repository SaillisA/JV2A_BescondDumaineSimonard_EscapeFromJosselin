using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PreloadDonnes : MonoBehaviour
{

    public int scenePrecedenteParametre = 0;        //si = 0 : l'ecran d'accueil etait avant les parametres; si = 1 : l'ecran pause etait avant;

    public float volumeMusique;

    public float volumeEffetSonore;

    public float volumeVoix;

    public float sensibilite;

    public string langueChoisis;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("SceneEcranAcceuil");
    }


}
