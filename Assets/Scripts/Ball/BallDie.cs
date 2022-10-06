using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDie : MonoBehaviour {
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private GameObject Hearts;

    private void OnCollisionEnter2D( Collision2D collision ) {
        if (collision.gameObject.name == "Bottom") {
            Destroy_Heart();
            Stop_Ball();
        }
    }

    void Destroy_Heart() {
        GameObject LastHeart = Hearts.transform.GetChild(Hearts.transform.childCount - 1).gameObject;
        Destroy(LastHeart);
    }

    void Stop_Ball() {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameObject.transform.parent = playerHealth.gameObject.transform.parent.transform;
        gameObject.transform.localPosition = Vector2.zero;
    }
}
