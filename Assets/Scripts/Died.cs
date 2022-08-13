using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Died : MonoBehaviour { 
    void Start() {
        Invoke("Restart", 5);
    }


    public void Restart() {
        SceneManager.LoadScene("Start");
    }
}
