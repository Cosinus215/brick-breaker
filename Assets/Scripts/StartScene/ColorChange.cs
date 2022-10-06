using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    private Color EndColor;
    private Color StartColor;

    void Start() {
        StartColor = GetComponent<Camera>().backgroundColor;
        StartCoroutine("ChangeColor", 0);
        EndColor = new Color(1, 1, 0.58f, 0);
    }

    private IEnumerator ChangeColor() {
        //while (true) {
            //Color32 lastcolor = GetComponent<Camera>().backgroundColor;
            float tick = 0f;
            while (GetComponent<Camera>().backgroundColor != EndColor) {
                tick += Time.deltaTime * 2;
                GetComponent<Camera>().backgroundColor = Color.Lerp(StartColor, EndColor, Mathf.PingPong(Time.time, 1));
                yield return null;
            }
            //yield return new WaitForSeconds(0.1f);
        //}
    }
}
