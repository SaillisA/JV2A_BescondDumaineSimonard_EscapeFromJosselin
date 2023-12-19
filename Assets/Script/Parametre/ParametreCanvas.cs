using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ParametreCanvas : MonoBehaviour
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

    public CameraRotation camSensi;     //pour modifier la sensibilite

    public string langueChoisisParametre;

    public GameObject canvasParametre;
    public GameObject canvasMenuPause;

    // Start is called before the first frame update
    void Start()
    {
        donnes = FindObjectOfType<PreloadDonnes>();
        sensibiliteParametre = donnes.sensibilite;
    }

    public void boutonRetour()
    {
        canvasParametre.gameObject.SetActive(false);
        canvasMenuPause.gameObject.SetActive(true);
    }
    public void ChangerVolumeMusique()
    {
        volumeMusiqueParametre = sliderMusique.value;
        donnes.volumeMusique = volumeMusiqueParametre;
        Debug.Log(volumeMusiqueParametre);
    }
    public void ChangerVolumeEffetSonore()
    {
        volumeEffetSonoreParametre = sliderEffetSonor.value;
        donnes.volumeEffetSonore = volumeEffetSonoreParametre;
        Debug.Log(volumeEffetSonoreParametre);
    }
    public void ChangerVolumeVoix()
    {
        volumeVoixParametre = sliderVoix.value;
        donnes.volumeVoix = volumeVoixParametre;
        Debug.Log(volumeVoixParametre);
    }
    public void ChangerSensibilite()
    {
        sensibiliteParametre = sliderSensibilite.value;
        camSensi.sensibilite = sensibiliteParametre;
        Debug.Log(sensibiliteParametre);
    }

    public void ChangerLangue()
    {
        Debug.Log("Langue changer");
    }
}
