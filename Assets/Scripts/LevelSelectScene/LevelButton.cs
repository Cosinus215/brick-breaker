using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour {
    public Button btn;
    public static string levelname;

    void Start() {
        btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick() {
        levelname = btn.name;
        SceneManager.LoadScene("Game");
    }
}
