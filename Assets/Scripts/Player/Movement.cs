using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] private float Speed;

    void Update() {
        Vector3 screenBorderLeft = Camera.main.WorldToScreenPoint((transform.position - gameObject.transform.localScale / 2 ) );
        Vector3 screenBorderRight = Camera.main.WorldToScreenPoint((transform.position + gameObject.transform.localScale / 2 ) );

        //move left
        if (screenBorderLeft.x > 0) {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
                transform.position += Vector3.right * -Speed * Time.deltaTime;
            }
        }

        //move right
        if (screenBorderRight.x < Screen.width) {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
                transform.position += Vector3.right * Speed * Time.deltaTime;
            }
        }

    }
}
