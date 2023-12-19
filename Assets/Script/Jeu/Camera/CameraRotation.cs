using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    private float xDeplacement;
    private float yDeplacement;
    private float xRotation;
    [SerializeField] private Transform joueurCorps;
    public Vector2 axesBloquer;

    public PreloadDonnes donnes;
    public float sensibilite = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        donnes = FindObjectOfType<PreloadDonnes>();
        sensibilite = donnes.sensibilite;
    }

    // Update is called once per frame
    void Update()
    {
        xDeplacement = axesBloquer.x * sensibilite * Time.deltaTime;
        yDeplacement = axesBloquer.y * sensibilite * Time.deltaTime;
        xRotation -= yDeplacement;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        joueurCorps.Rotate(Vector3.up * xDeplacement);
    }
}
