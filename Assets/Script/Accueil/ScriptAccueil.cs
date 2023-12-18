using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ScriptAccueil : MonoBehaviour
{
    public PreloadDonnes donnes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        donnes = FindObjectOfType<PreloadDonnes>();
    }

    public void boutonAllerParametre()
    {
        donnes.scenePrecedenteParametre = 0;
        Debug.Log("go dans les parametres");
        SceneManager.LoadScene("SceneParametre");
    }

    public void boutonAllerSelectionNiveau()
    {
        Debug.Log("go dans la selection de niveau");
        SceneManager.LoadScene("SceneSelectionNiveau");
    }
    public void boutonQuitterLeJeu()
    {
        Debug.Log("le jeu est fermer hihi");
    }
}
