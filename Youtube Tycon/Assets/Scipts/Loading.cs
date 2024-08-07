using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{

    public string loadLevel;

    public GameObject loadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load ()
    {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(loadLevel); 
    }
}
