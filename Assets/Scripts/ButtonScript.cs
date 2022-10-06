using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
    private Button btn;
    public static string levelname;

    void Start() {
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() {
        if (btn.name == "Pause") {
            //pause game
        } else if (btn.name == "Start") {
            SceneManager.LoadScene("ChooseLevel");
        } else {
            levelname = btn.name;
            SceneManager.LoadScene("Game");
        }
    }
}
