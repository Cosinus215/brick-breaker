using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {
    private int Health;
    private Sprite BlockSprite;
    private Sprite HardBlockSprite;
    private GameObject Boost;

    private void Start() {
        HardBlockSprite = Resources.Load<Sprite>("Sprite/Hard Block");
        BlockSprite = Resources.Load<Sprite>("Sprite/Block");
        Boost = Resources.Load<GameObject>("Boost");

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
                AllFunc(collision);
                Destroy(this.gameObject);
            } else if (Health == 2) {
                Health--;
            }
        }
    }

    public void AllFunc( Collision2D collision ) {
        int randomNum = Random.Range(0, 4);
        switch (randomNum) {
            case 0:
                break;
            case 1:
                GameObject RandomBoosdt = Instantiate(Boost);
                RandomBoosdt.transform.position = gameObject.transform.position;
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
}
