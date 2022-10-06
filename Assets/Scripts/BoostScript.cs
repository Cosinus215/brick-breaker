using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour {
    private int randomNum;
    private GameObject Player;

    void Start() {
        randomNum = Random.Range(0, 2);
        Color_boost();
    }

    private void OnTriggerEnter2D( Collider2D collision ) {
        if (collision.gameObject.CompareTag("Player")) {
            Player = collision.gameObject;

            Player_size();

            //Go back to previous size
            Invoke("Clean", 3);
        }
    }

    void Color_boost() {
        switch (randomNum) {
            case 0:
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 23, 255);
                break;
            case 1:
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 17, 0, 255);
                break;
        }
    }

    void Player_size() {
        switch (randomNum) {
            case 0:
                //green
                Player.transform.localScale = new Vector3(Player.transform.localScale.x + 1, Player.transform.localScale.y, Player.transform.localScale.z);
                break;
            case 1:
                //red
                if (Player.transform.localScale.x != 1) {
                    Player.transform.localScale = new Vector3(Player.transform.localScale.x - 1, Player.transform.localScale.y, Player.transform.localScale.z);
                }
                break;
                
                //TODO: use scriptable object instead of this
        }
    }

    public void Clean() {
        Player.gameObject.transform.localScale = new Vector3(3, 0.5f, 1);
        Destroy(gameObject);
    }
}
