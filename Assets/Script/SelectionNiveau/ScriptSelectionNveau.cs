using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptSelectionNveau : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void retourEcranAccueil()
    {
        SceneManager.LoadScene("SceneEcranAcceuil");
    }
    public void NiveauTutoriel()
    {
        Debug.Log("on va dans le tuto ! yippy");
        SceneManager.LoadScene("Level_00_Tutorial");
    }
}
