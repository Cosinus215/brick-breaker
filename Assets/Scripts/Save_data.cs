using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_data {
    public void Save() {
        if (PlayerPrefs.GetInt("Level") < BlockGenerate.Player_Level) {
            PlayerPrefs.SetInt("Level", BlockGenerate.Player_Level);
            PlayerPrefs.Save();
        }
    }
}
