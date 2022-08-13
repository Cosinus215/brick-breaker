using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDie : MonoBehaviour {
    public PlayerHealth playerHealth;
    public GameObject Hearts;

    private void Update() {

    }

    private void OnCollisionEnter2D( Collision2D collision ) {
        if (collision.gameObject.name == "Bottom") {
            GameObject LastHeart = Hearts.transform.GetChild(Hearts.transform.childCount - 1).gameObject;
            Destroy(LastHeart);
            this.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.gameObject.transform.parent = playerHealth.gameObject.transform.parent.transform;
            this.gameObject.transform.localPosition = Vector2.zero;
        }
    }
}
