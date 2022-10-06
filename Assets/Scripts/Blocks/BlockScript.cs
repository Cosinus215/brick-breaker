using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {
    private int Health;
    private Sprite BlockSprite;
    private Sprite HardBlockSprite;
    private GameObject Boost;

    private void Start() {
        Load_Resources();
        Set_Random_block();
    }

    private void OnCollisionEnter2D( Collision2D collision ) {
        if (collision.gameObject.name == "Ball") {
            if (Health == 1) {
                AllFunc(collision);
                Destroy(gameObject);
            } else if (Health == 2) {
                GetComponent<SpriteRenderer>().sprite = BlockSprite;
                Health--;
            }
        }
    }

    void Load_Resources() {
        HardBlockSprite = Resources.Load<Sprite>("Sprite/Hard Block");
        BlockSprite = Resources.Load<Sprite>("Sprite/Block");
        Boost = Resources.Load<GameObject>("Boost");
    }

    void Set_Random_block() {
        //Pick random health
        Health = Random.Range(1, 3);

        //Pick Random color
        GetComponent<SpriteRenderer>().color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);

        //Set correct sprite
        if (Health == 2) {
            //Set the block to hardblock
            GetComponent<SpriteRenderer>().sprite = HardBlockSprite;
        } else if (Health == 1) {
            //Set the block to normalblock
            GetComponent<SpriteRenderer>().sprite = BlockSprite;
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
