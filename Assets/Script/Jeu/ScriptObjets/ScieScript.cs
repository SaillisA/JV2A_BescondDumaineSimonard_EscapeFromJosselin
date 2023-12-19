using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScieScript : MonoBehaviour
{
    public GameObject scieGameObject;
    public bool scieTrouvee = false;
    public PnjPierre pierreParle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TrouverScie()
    {
        if(scieTrouvee == false)
        {
            Debug.Log("Scie Trouvée");
            Destroy(scieGameObject);
            scieTrouvee = true;
            pierreParle.DialoguePierreScie();
        }
    }
}
