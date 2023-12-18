using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasDePlanche : MonoBehaviour
{

    public Inventaire barreInventaire;
    public int planchesNecessaires = 3;             //le joueur doit emmener 3 planches;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeposerPlanches()
    {
        Debug.Log("je pose des planches");
    }
}
