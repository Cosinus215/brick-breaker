using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour {
    private Rigidbody2D rb;
    private Vector3 lastVelocity;

    void Awake() {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update() {
        lastVelocity = rb.velocity;
    }

    private void OnCollisionEnter2D( Collision2D collision ) {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);
    }
}
