using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EcranCamera : MonoBehaviour
{
    public FixedTouchField _fixedTouchField;
    public CameraRotation cameraJoueur;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraJoueur.axesBloquer = _fixedTouchField.TouchDist;
    }
}
