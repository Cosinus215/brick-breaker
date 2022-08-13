using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockGenerate : MonoBehaviour {
    private int RandomNumber;
    private List<Vector2> Position = new List<Vector2>();

    private void Start() {
        if (LevelButton.levelname == "Easy") { RandomNumber = Random.Range(10, 15); }
        else if (LevelButton.levelname == "Medium") { RandomNumber = Random.Range(20, 25); }
        else if (LevelButton.levelname == "Hard") { RandomNumber = Random.Range(30, 35); }

        Debug.Log(LevelButton.levelname);
        for (int i = 0; i < RandomNumber; i++) {
            GameObject Block = new GameObject();
            Block.transform.parent = this.gameObject.transform;
            Block.tag = "Block";
            Block.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            Block.AddComponent<SpriteRenderer>();
            Block.AddComponent<BoxCollider2D>();
            Block.AddComponent<BlockScript>();

            

            Block.GetComponent<BoxCollider2D>().size = new Vector2(1, 1);

            Vector2 randomPos = new Vector2(Random.Range(-8f, 8), Random.Range(0,4));

            if (Position.Count != 0) {
                for (int j = 0; j < Position.Count; j++) {
                    if (( Vector2.Distance(Position[j], randomPos) < 0.7f )) {
                        randomPos = new Vector2(Random.Range(-8f, 8), Random.Range(0, 4));
                        j = 0;
                    }

                    if (j + 1 == Position.Count) {
                        Block.transform.position = randomPos;
                        Position.Add(randomPos);
                        break;
                    }
                }

            } else if (Position.Count == 0) {
                Block.transform.position = randomPos;
                Position.Add(randomPos);
            }
        }
    }
}
