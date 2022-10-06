using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Died : MonoBehaviour { 
    void Start() {
        //Wait for 5 seconds
        Invoke("Restart", 5);
    }


    void Restart() {
        //Load main scene
        SceneManager.LoadScene("Start");
    }
}
