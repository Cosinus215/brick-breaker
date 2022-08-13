using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {
    private int Health;
    private Sprite BlockSprite;
    private Sprite HardBlockSprite;

    private void Start() {
        HardBlockSprite = Resources.Load<Sprite>("Sprite/Hard Block");
        BlockSprite = Resources.Load<Sprite>("Sprite/Block");
        Health = Random.Range(1, 3);
        GetComponent<SpriteRenderer>().color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
    }

    private void Update() {
        if (Health == 2) {
            GetComponent<SpriteRenderer>().sprite = HardBlockSprite;
        } else if (Health == 1) {
            GetComponent<SpriteRenderer>().sprite = BlockSprite;
        }
    }

    private void OnCollisionEnter2D( Collision2D collision ) {
        if (collision.gameObject.name == "Ball") {
            if (Health == 1) {
                Destroy(this.gameObject);
            } else if (Health == 2) {
                Health--;
            }
        }
    }
}
