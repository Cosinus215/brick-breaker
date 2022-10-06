using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    [SerializeField] private int Health;
    [SerializeField] private GameObject Hearts;

    private void Update() {
        Health = Hearts.transform.childCount;

        if (Health == 0) {
            SceneManager.LoadScene("Die");
        }
    }

}