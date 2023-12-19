using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PnjOuvrier : MonoBehaviour
{

    public bool dialogueOuvrier = false;
    public bool dialoguePierre = false;

    public GameObject scieGameObject;
    public bool scieTrouvee = false;
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
        if(dialogueOuvrier == false)
        {
            boutonTexte.gameObject.SetActive(true);
            nomTextePnj.text = "Ouvrier";
            textePnj.text = "Où est ma scie ?!";
            dialogueOuvrier=true;
        }
       
    }

    public void boutonOuvrier()
    {
        if(dialoguePierre == false)
        {
            nomTextePnj.text = "Pierre";
            textePnj.text = "On va te la trouver, viens m’aider toi. J'suis persuadé qu'il l'a perdue dans le coin ";
            dialoguePierre = true;
        }
        else
        {
            boutonTexte.gameObject.SetActive(false);
        }
    }

    
}
