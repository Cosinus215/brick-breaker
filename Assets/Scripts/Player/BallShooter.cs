using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour {
    [SerializeField] private Rigidbody2D Ball;
    private Vector2 shootDirection;

    private void Update() {
        if (Input.GetMouseButtonDown(0) && gameObject.transform.parent.transform.Find("Ball")) {
            Shoot_Ball();
        }

        if (transform.parent.transform.Find("Ball")) {
            Stop_Ball();
        }
    }

    void Shoot_Ball() {
        shootDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - gameObject.transform.position);
        Ball.velocity = new Vector2(shootDirection.x, shootDirection.y).normalized * 10;
        Ball.transform.parent = null;
    }

    void Stop_Ball() {
        transform.parent.transform.Find("Ball").transform.localPosition = gameObject.transform.localPosition + new Vector3(0, 0.5f, 0);
    }

}
