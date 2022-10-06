using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockGenerate : MonoBehaviour {
    private int RandomNumber;
    private List<Vector2> Position = new List<Vector2>();

    private void Start() {
        //Choose the number of blocks
        if (ButtonScript.levelname == "Easy") { RandomNumber = Random.Range(10, 15); }
        else if (ButtonScript.levelname == "Medium") { RandomNumber = Random.Range(20, 25); }
        else if (ButtonScript.levelname == "Hard") { RandomNumber = Random.Range(30, 35); } 
        else { RandomNumber = Random.Range(20, 30); }

        //Generate the chosen number of blocks
        for (int i = 0; i < RandomNumber; i++) {
            Generate_blocks();
        }
    }

    private void Update() {
        if (Time.time > 3 && transform.childCount == 0) {
            SceneManager.LoadScene("Win");
        }
    }


    void Generate_blocks() {
        //Create new Gameobject
        GameObject Block = new GameObject();
        Block.transform.parent = gameObject.transform;
        Block.tag = "Block";
        Block.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        //Add component to the blocks
        Block.AddComponent<SpriteRenderer>();
        Block.AddComponent<BoxCollider2D>();
        Block.AddComponent<BlockScript>();

        //Edit the component
        Block.GetComponent<BoxCollider2D>().size = new Vector2(1, 1);

        //Locate blocks in the correct places
        Locate_blocks(Block);
    }
    void Locate_blocks(GameObject Block) {
        //Create new random place
        Vector2 randomPos = new Vector2(Random.Range(-8f, 8), (int)Random.Range(-1.4f, 4.4f));

        if (Position.Count != 0) {
            for (int j = 0; j < Position.Count; j++) {
                //Pick new random place if they are in the same/near places
                if ((Vector2.Distance(Position[j], randomPos) < 0.7f)) {
                    randomPos = new Vector2(Random.Range(-8f, 8), (int)Random.Range(-1.4f, 4.4f));
                    j = 0;
                }

                //Set the position of block and add it to the list if random positiom is correct
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
