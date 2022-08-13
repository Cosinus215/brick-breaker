using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostScript : MonoBehaviour {
    public int randomNum;
    private GameObject Player;

    void Start() {
        randomNum = Random.Range(0, 2);

        switch (randomNum) {
            case 0:
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(0, 255, 23, 255);
                break;
            case 1:
                gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 17, 0, 255);
                break;
        }
    }

    private void OnTriggerEnter2D( Collider2D collision ) {
        if (collision.gameObject.tag == "Player") {
            Player = collision.gameObject;

            switch (randomNum) {
                case 0:
                    Player.transform.localScale = new Vector3(Player.transform.localScale.x + 1, Player.transform.localScale.y, Player.transform.localScale.z);
                    break;
                case 1:
                    Player.transform.localScale = new Vector3(Player.transform.localScale.x - 1, Player.transform.localScale.y, Player.transform.localScale.z);
                    break;
            }

            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
            Invoke("Clean", 3);
            
        }
    }

    void Update() {

    }

    public void Clean() {
        Player.gameObject.transform.localScale = new Vector3(3, 0.5f, 1);
        Destroy(this.gameObject);
    }
}
