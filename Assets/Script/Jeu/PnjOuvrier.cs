using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PnjOuvrier : MonoBehaviour
{



    //texte :
    public GameObject boutonTexte;
    public TextMeshProUGUI textePnj;
    public TextMeshProUGUI nomTextePnj;

    // Start is called before the first frame update
    void Start()
    {
        boutonTexte.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ParlerOuvrier()
    {
        boutonTexte.gameObject.SetActive(true);
        nomTextePnj.text = "Ouvrier";
        textePnj.text = "Où est ma scie ?!";
    }

    public void boutonOuvrier()
    {
        boutonTexte.gameObject.SetActive(false);
    }
}
