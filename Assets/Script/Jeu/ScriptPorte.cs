using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPorte : MonoBehaviour
{
    public PnjPierre pierreBool;

    public void FinJeuPorte()
    {
        if(pierreBool.finDuJeu == true)
        {
            Debug.Log("niveauTerminé");
        }
    }
}
