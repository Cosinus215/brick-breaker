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

        if (BlockGenerate.Player_Level == 0 && btn.name == "Easy") {
            BlockGenerate.Player_Level = 1;
        }
        if (BlockGenerate.Player_Level == 2 && btn.name == "Medium") {
            btn.GetComponent<Button>().interactable = true;
        } 
        if (BlockGenerate.Player_Level == 3 && (btn.name == "Hard" || btn.name == "Medium")) {
            btn.GetComponent<Button>().interactable = true;
        }

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
