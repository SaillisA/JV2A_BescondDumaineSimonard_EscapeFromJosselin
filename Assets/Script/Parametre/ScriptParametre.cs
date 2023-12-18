using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptParametre : MonoBehaviour
{
    public PreloadDonnes donnes;
    //si la scene precedente est l'accueil alors scenePrecedente = 0; si c'est le menu pause alors = 1;
    public int scenePrecedente = 0;

    public Slider sliderMusique;
    public float volumeMusiqueParametre;

    public Slider sliderEffetSonor;
    public float volumeEffetSonoreParametre;

    public Slider sliderVoix;
    public float volumeVoixParametre;

    public Slider sliderSensibilite;
    public float sensibiliteParametre;

    public string langueChoisisParametre;

    // Start is called before the first frame update
    void Start()
    {
        donnes = FindObjectOfType<PreloadDonnes>();
    }

    public void boutonRetour()
    {
        if(scenePrecedente == 0)
        {
            Debug.Log("on retourne a l'ecran d'accueil");
            SceneManager.LoadScene("SceneEcranAcceuil");
        }
        if (scenePrecedente == 1)
        {
            Debug.Log("on retourne a l'ecran pause");
        }
        else
        {
            Debug.Log("euh y'a un probleme la");
        }
    }
    public void changerVolumeMusique()
    {
        volumeMusiqueParametre = sliderMusique.value;
        donnes.volumeMusique = volumeMusiqueParametre;
        Debug.Log(volumeMusiqueParametre);
    }
    public void changerVolumeEffetSonore()
    {
        volumeEffetSonoreParametre = sliderEffetSonor.value;
        donnes.volumeEffetSonore = volumeEffetSonoreParametre;
        Debug.Log(volumeEffetSonoreParametre);
    }
    public void changerVolumeVoix()
    {
        volumeVoixParametre = sliderVoix.value;
        donnes.volumeVoix = volumeVoixParametre;
        Debug.Log(volumeVoixParametre);
    }
    public void changerSensibilite()
    {
        sensibiliteParametre = sliderSensibilite.value;
        donnes.sensibilite = sensibiliteParametre;
        Debug.Log(sensibiliteParametre);
    }

    public void changerLangue()
    {
        Debug.Log("Langue changer");
    }

}
