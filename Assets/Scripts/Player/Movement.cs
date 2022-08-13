using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float Speed;

    void Update() {
        Vector3 screenBorderLeft = Camera.main.WorldToScreenPoint((this.transform.position - gameObject.transform.localScale / 2 ) );
        Vector3 screenBorderRight = Camera.main.WorldToScreenPoint((this.transform.position + gameObject.transform.localScale / 2 ) );

        if (screenBorderLeft.x > 0) {
            if (Input.GetKey(KeyCode.A)) {
                transform.position += Vector3.right * -Speed * Time.deltaTime;
            }
        }

        if (screenBorderRight.x < Screen.width) {
            if (Input.GetKey(KeyCode.D)) {
                transform.position += Vector3.right * Speed * Time.deltaTime;
            }
        }

    }
}
