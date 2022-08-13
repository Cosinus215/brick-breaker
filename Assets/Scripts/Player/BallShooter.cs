using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour {
    public Rigidbody2D Ball;
    public Vector2 shootDirection;

    private void Start() {
        //Ball = GameObject.Find("Ball");
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0) && this.gameObject.transform.Find("Ball")) {
            shootDirection = ( Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.gameObject.transform.position );
            Ball.velocity = new Vector2(shootDirection.x, shootDirection.y).normalized * 10;
            Ball.transform.parent = null;
        }
    }

}
