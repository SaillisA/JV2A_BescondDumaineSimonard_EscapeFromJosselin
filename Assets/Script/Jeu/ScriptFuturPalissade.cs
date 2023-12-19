using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFuturPalissade : MonoBehaviour
{
    // Start is called before the first frame update
    public PnjPierre pierre;
    public void ConstruirePalissade()
    {
        Debug.Log("la palissade est faite");
        pierre.DialoguePierreFinNiveau();
    }
}
