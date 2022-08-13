using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {

    private void Start() {
    }

    private void Update() { 
    }

    private void OnCollisionEnter2D( Collision2D collision ) {
        if (collision.gameObject.name == "Ball") {
            Destroy(this.gameObject);
        }

        //if (collision.gameObject.tag == "Block") {
        //collision.gameObject.transform.position = new Vector2(Random.Range(-8f, 8), Random.Range(0, 4));
        //}
    }

    private void OnCollisionStay2D( Collision2D collision ) {
        //if (collision.gameObject.tag == "Block") {
            Debug.Log("a");
        //}
    }
}
