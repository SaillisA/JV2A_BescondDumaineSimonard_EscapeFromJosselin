using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMenuPause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvasEnJeu, canvasMenuPause, CanvasParametre;

    public void RetourEnJeu()
    {
        canvasMenuPause.gameObject.SetActive(false);
        canvasEnJeu.gameObject.SetActive(true);
    }
    public void AllerParametre()
    {
        canvasMenuPause.gameObject.SetActive(false);
        CanvasParametre.gameObject.SetActive(true);
    }
}
