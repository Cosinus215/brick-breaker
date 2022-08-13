using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockGenerate : MonoBehaviour {
    public int RandomNumber;
    public Sprite BlockSprite;
    public List<Vector2> Position = new List<Vector2>();

    private void Start() {
        RandomNumber = Random.Range(10, 20);
        for (int i = 0; i < RandomNumber; i++) {
            GameObject Block = new GameObject();
            Block.tag = "Block";

            Block.AddComponent<SpriteRenderer>();
            Block.AddComponent<BoxCollider2D>();
            Block.AddComponent<BlockScript>();

            Block.GetComponent<SpriteRenderer>().sprite = BlockSprite;
            Block.GetComponent<SpriteRenderer>().color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);

            Block.GetComponent<BoxCollider2D>().size = new Vector2(1, 1);

            Vector2 randomPos = new Vector2(Random.Range(-8f, 8), Random.Range(0,4));

            if (Position.Count != 0) {
                for (int j = 0; j < Position.Count; j++) {
                    if (( Vector2.Distance(Position[j], randomPos) < 1.5f )) {
                        randomPos = new Vector2(Random.Range(-8f, 8), Random.Range(0, 4));
                        j = 0;
                        //for (int k = 0; k < Position.Count; k++) {
                        //    if (( Vector2.Distance(Position[k], randomPos) < 1.5f )) {
                        //        j = 0;
                        //        break;
                        //    } else if (k + 1 == Position.Count) {
                        //        Block.transform.position = randomPos;
                        //        Position.Add(randomPos);
                        //    }
                        //}
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
                //return;
            }


            //int randomx = Random.Range(-8, 8);
            //int randomy = Random.Range(0,4);
            // StartCoroutine(LookPos(randomPos));
            //var minePositions = CreateMinePositions(29, new Vector3(-10, -10, -10), new Vector3(10, 10, 10), 3);
            //Block.transform.position = minePositions;
            //Instantiate(Block, minePositions);
            //Position.Add(randomPos);
            //Check the distance beetwen each position from a list to random Pos
        }
    }


    //IEnumerator LookPos( Vector2 randomPos ) {
    //    if (Position.Contains(randomPos /* TODO : Check if the "randomPos" is inside another vector2 from the list */)) {
    //        randomPos = new Vector2(Random.Range(-8f, 8), Random.Range(0, 4));
    //    }
    //    yield return new WaitUntil(() => !Position.Contains(randomPos + new Vector2(3, 3)));
    //}


    //private void Start() {
    //    var minePositions = CreateMinePositions(29, new Vector3(-10, -10, -10), new Vector3(10, 10, 10), 3);
    //
    //    // InstantiateMines(minePositions);
    //}

    //private IEnumerable<Vector3> CreateMinePositions( int mineCount, Vector3 minimalPosition, Vector3 maximalPosition, float minimalDistance ) {
    //    var positions = new List<Vector3>();
    //
    //    for (var i = 0; i < mineCount; i++) {
    //        Vector3 position;
    //
    //        do {
    //            position = new Vector3(
    //                Random.Range(minimalPosition.x, maximalPosition.x),
    //                Random.Range(minimalPosition.y, maximalPosition.y),
    //                Random.Range(minimalPosition.z, maximalPosition.z));
    //        } while (positions.Any(p => Vector3.Distance(position, p) < minimalDistance));
    //
    //        positions.Add(position);
    //    }
    //
    //    return positions;
    //}
}
