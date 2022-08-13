using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boosters : MonoBehaviour {
    public Rigidbody2D Ball;
    public GameObject CollectedBooster;

    private void OnCollisionEnter2D( Collision2D collision ) {
        if (collision.gameObject.name == "Ball" && CollectedBooster != null) {

            Ball.velocity = Vector2.zero;
            Ball.transform.parent = this.gameObject.transform;
            Ball.transform.localPosition = new Vector2(0, 1);
        }
    }
}
